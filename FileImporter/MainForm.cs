using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using FilesImporter;
using System.Collections;
using System.Threading;
using SharpCompress.Reader;
using ImportFiles;

namespace FilesImporter
{
    // test comment2
    public partial class MainForm : Form
    {
        private UserControl[] userControls;

        private FileChooseMenu fileChooseMenu = new FileChooseMenu();
        private DelimiterChooseMenu delimitersMenu = new DelimiterChooseMenu();
        private FinishMenu FinishMenu = new FinishMenu();

        private FileImporter importer = null;
        private LogAnalyzer analyzer = new LogAnalyzer();

        private string FolderPath
        {
            get { return fileChooseMenu.txtFolderPath.Text; }
            set { fileChooseMenu.txtFolderPath.Text = value; }
        }

        private string FilePath
        {
            get { return FolderPath + "\\" + fileChooseMenu.lbxFolderFiles.SelectedItem; }
        }

        private string DirectoryPath
        {
            get { return fileChooseMenu.txtDbDir.Text; }
            set { fileChooseMenu.txtDbDir.Text = value; }
        }

        private string Mask
        {
            get { return fileChooseMenu.cmbMask.Text; }
            set { fileChooseMenu.cmbMask.Text = value; }
        }

        private int SkipLines
        {
            get { return Int32.Parse(fileChooseMenu.cmbSkipLines.Text); }
        }

        private char[] Delimiters
        {
            get
            {
                List<char> delimiters = new List<char>();

                if (delimitersMenu.chkDelimiterComma.Checked)
                    delimiters.Add(',');
                if (delimitersMenu.chkDelimiterSemicolon.Checked)
                    delimiters.Add(';');
                if (delimitersMenu.chkDelimiterOther.Checked)
                    delimiters.Add(delimitersMenu.txbDelimiterOther.Text[0]);

                return delimiters.ToArray();
            }
        }

        private StringSplitOptions SplitOptions
        {
            get
            {
                StringSplitOptions splitOption = new StringSplitOptions();
                if (delimitersMenu.rbtnNaNSplitOption.Checked)
                    splitOption = StringSplitOptions.None;
                if (delimitersMenu.rbtnRemoveEmptyEntriesSplitOption.Checked)
                    splitOption = StringSplitOptions.RemoveEmptyEntries;

                return splitOption;
            }
        }

        private bool CompressedFiles
        {
            get { return fileChooseMenu.chkCompressedFiles.Checked; }
        }

        private Type[] Types
        {
            get
            {
                List<Type> types = new List<Type>();
                string rowTypes = "";

                for (int i = 1; i < grdTableLines.ColumnCount; i++)
                {
                    rowTypes = grdTableLines.Rows[0].Cells[i].Value.ToString();
                    types.Add(ImportUtils.GetType(rowTypes));
                }
                return types.ToArray();
            }
        }

        private string DecimalSeparator
        {
            get { return delimitersMenu.cmbDecimalSeparator.Text; }
        }

        private DateTimeFormatInfo DateTime
        {
            get
            {
                DateTimeFormatInfo dateTime = new DateTimeFormatInfo();

                ((DateTimeFormatInfo)dateTime).ShortTimePattern = delimitersMenu.cmbShortTime.Text;
                ((DateTimeFormatInfo)dateTime).LongTimePattern = delimitersMenu.cmbLongTime.Text;
                ((DateTimeFormatInfo)dateTime).ShortDatePattern = delimitersMenu.cmbShortDate.Text;
                ((DateTimeFormatInfo)dateTime).LongDatePattern = delimitersMenu.cmbLongDate.Text;

                return dateTime;
            }
        }
        private int LinesToRead
        {
            get { return Int32.Parse(fileChooseMenu.cmbLinesToRead.Text); }
        }

        private int FilesCount
        {
            get { return fileChooseMenu.lbxFolderFiles.Items.Count; }
        }

        private string[] RowTypes = new string[] { "System.Boolean", "System.Byte ", "System.SByte", "System.Char", "System.Decimal", "System.Double", "System.Single", "System.Int32", "System.UInt32", "System.Int64", "System.UInt64", "System.Int16", "System.UInt16", "System.String", "DateTime" };

        int index = 0;

        public MainForm()
        {
            InitializeComponent();
            SetDefultValues();
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            Controls.Add(userControls[0]);
        }

        private void btnBrowseDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirBrowseDialog = new FolderBrowserDialog();

            if (dirBrowseDialog.ShowDialog() == DialogResult.OK)
                DirectoryPath = dirBrowseDialog.SelectedPath;
        }

        private void btnBrowseFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog();

            if (folderBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowseDialog.SelectedPath;
                DirectoryInfo info = new DirectoryInfo(FolderPath);
                AddFileNames(info, info.GetFiles(Mask, SearchOption.TopDirectoryOnly));
            }
        }

        private void cmbMask_SelectIndexChanged(object sender, EventArgs e)
        {
            if (fileChooseMenu.txtFolderPath.Text.Length > 0)
            {
                DirectoryInfo info = new DirectoryInfo(FolderPath);
                AddFileNames(info, info.GetFiles(Mask, SearchOption.TopDirectoryOnly));
            }
        }

        private void lbxFolderFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileChooseMenu.lbxFolderFiles.SelectedItem == null)
                return;

            SetLines(ImportUtils.ReadFile(FilePath, SkipLines, LinesToRead));
        }

        public void Delimiters_CheckedChanged(object sender, EventArgs e)
        {
            SplitLines(Delimiters);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SplitLines(Delimiters);
            Controls.Remove(userControls[0]);
            Controls.Add(userControls[1]);
            index = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Controls.Remove(userControls[1]);
            Controls.Add(userControls[0]);
            index = 0;

            SetLines(ImportUtils.ReadFile(FilePath, SkipLines, LinesToRead));
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Controls.Remove(userControls[0]);
            Controls.Remove(userControls[1]);
            Controls.Add(userControls[2]);

            index = 2;
            if (index == 2)
                grdTableLines.Hide();

            ShowSettingsTxb();

            btnStart.Show();
            btnStop.Show();
            btnFinish.Hide();
            btnNext.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controls.Remove(userControls[2]);
            Controls.Add(userControls[0]);

            grdTableLines.Show();
            FinishMenu.txbSettings.Clear();
            FinishMenu.txbProgress.Clear();

            index = 0;

            SetLines(ImportUtils.ReadFile(FilePath, SkipLines, LinesToRead));

            btnFinish.Show();
            btnNext.Show();
            btnStart.Hide();
            btnStop.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            analyzer.SetDefultValue();
            IFormatProvider[] providers = ImportUtils.GetProviders(Types, DecimalSeparator, DateTime);

            importer = new FileImporter(FolderPath, DirectoryPath, Mask, CompressedFiles, SkipLines, Types, Delimiters, providers);
            importer.Log += EventHandler;
            importer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            importer.Stop();
        }

        public void EventHandler(FileImporter sender, string msg)
        {
            try { Invoke(new Action<string>(OnReportProgress), msg); }
            catch { }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            fileChooseMenu.lbxFolderFiles.Enabled = fileChooseMenu.cmbSkipLines.Text.Length > 0;

            //buttons
            btnBack.Enabled = index == 1;
            btnFinish.Enabled = index == 1;
            btnCancel.Enabled = index == 2 && !btnStop.Enabled;

            btnStart.Enabled = !analyzer.IsWorking;
            btnStop.Enabled = analyzer.IsWorking;
            btnNext.Enabled = fileChooseMenu.lbxFolderFiles.SelectedItem != null && fileChooseMenu.txtDbDir.Text.Length != 0 && index == 0;

            if (analyzer.IsWorking == true)
                ShowProgress();
        }

        #endregion

        private void AddFileNames(DirectoryInfo info, FileInfo[] files)
        {
            fileChooseMenu.lbxFolderFiles.Items.Clear();

            foreach (var file in files)
                fileChooseMenu.lbxFolderFiles.Items.Add(file);
        }

        private void SetDefultValues()
        {
            userControls = new UserControl[] { fileChooseMenu, delimitersMenu, FinishMenu };

            //Events
            fileChooseMenu.btnBrowseFolderPath.Click += new EventHandler(btnBrowseFolderPath_Click);
            fileChooseMenu.lbxFolderFiles.SelectedIndexChanged += new EventHandler(lbxFolderFiles_SelectedIndexChanged);
            fileChooseMenu.btnBrowseDbDir.Click += new EventHandler(btnBrowseDir_Click);
            fileChooseMenu.cmbMask.SelectedIndexChanged += new EventHandler(cmbMask_SelectIndexChanged);

            delimitersMenu.chkDelimiterComma.CheckedChanged += new EventHandler(Delimiters_CheckedChanged);
            delimitersMenu.chkDelimiterSemicolon.CheckedChanged += new EventHandler(Delimiters_CheckedChanged);
            delimitersMenu.chkDelimiterOther.CheckedChanged += new EventHandler(Delimiters_CheckedChanged);
            delimitersMenu.rbtnNaNSplitOption.CheckedChanged += new EventHandler(Delimiters_CheckedChanged);
            delimitersMenu.rbtnRemoveEmptyEntriesSplitOption.CheckedChanged += new EventHandler(Delimiters_CheckedChanged);

            //User elements
            fileChooseMenu.cmbLinesToRead.Text = "10";
            fileChooseMenu.cmbSkipLines.Text = "0";
            fileChooseMenu.cmbMask.Text = "*.*";

            delimitersMenu.cmbShortDate.Text = "m/d/yy";
            delimitersMenu.cmbLongDate.Text = "dddd, mmmm d, yyyy";
            delimitersMenu.cmbShortTime.Text = "h:mm tt";
            delimitersMenu.cmbLongTime.Text = "h:mm:ss tt";
            delimitersMenu.cmbDecimalSeparator.Text = ".";

            menuStrip.Dock = DockStyle.Top;
            FinishMenu.Dock = DockStyle.Fill;
            fileChooseMenu.Dock = DockStyle.Fill;
        }

        private void SetLines(List<string> lines)
        {
            ClearGridView();

            grdTableLines.RowCount = lines.Count + 1;
            grdTableLines.Rows[0].Cells[0].Value = "Lines";

            for (int i = 0; i < lines.Count; i++)
                grdTableLines.Rows[i + 1].Cells[0].Value = lines[i];
        }

        private void SplitLines(char[] delimiters)
        {
            List<string> Lines = ImportUtils.ReadFile(FilePath, SkipLines, LinesToRead);

            ClearGridView();
            SetLines(Lines);
            grdTableLines.Rows[0].Cells[0].Value = "Lines / Types";

            for (int row = 0; row < grdTableLines.RowCount - 1; row++)
            {
                string[] arr = new string[] { Lines[row] };

                if (delimiters.Length > 0)
                    arr = Lines[row].Split(delimiters, SplitOptions);

                if (arr.Length + 1 > grdTableLines.ColumnCount)
                {
                    grdTableLines.ColumnCount = arr.Length + 1;
                    AddTypes(arr.Length);
                }

                for (int col = 0; col < arr.Length; col++)
                    grdTableLines.Rows[row + 1].Cells[col + 1].Value = arr[col];
            }
        }

        private void AddTypes(int count)
        {
            grdTableLines.ColumnCount = count + 1;

            for (int i = 1; i < count + 1; i++)
            {
                DataGridViewComboBoxCell comboBox = new DataGridViewComboBoxCell();
                foreach (var rowType in RowTypes)
                    comboBox.Items.Add(rowType);

                grdTableLines[i, 0] = comboBox;
                grdTableLines.Rows[0].Cells[i].Value = RowTypes[13];
            }
        }

        private void OnReportProgress(string message)
        {
            Log(message);
        }

        private void Log(string message)
        {
            analyzer.Analyze(message);
        }

        private void ShowSettingsTxb()
        {
            StringBuilder builder = new StringBuilder();

            string delimiters = "";
            string types = "{ ";
            foreach (var delimiter in Delimiters)
                delimiters += delimiter + " ";

            foreach (var type in Types)
                types += type + " ; ";
            types += "}";

            builder.AppendLine(string.Format("{0}", DirectoryPath));
            builder.AppendLine(string.Format("{0}", FolderPath));
            builder.AppendLine(string.Format("{0}", CompressedFiles));
            builder.AppendLine(string.Format("{0}", SkipLines));
            builder.AppendLine(string.Format("{0}", Mask));
            builder.AppendLine(string.Format("{0}", delimiters));
            builder.AppendLine(string.Format("{0}", types));

            FinishMenu.txbSettings.Text = builder.ToString();
        }

        private void ShowProgress()
        {
            StringBuilder builderProgress = new StringBuilder();

            builderProgress.AppendLine(string.Format("{0}/{1}", analyzer.FilePassed, FilesCount));
            builderProgress.AppendLine(string.Format("{0} KB", analyzer.SizePassed));
            builderProgress.AppendLine(string.Format("{0}", analyzer.LineCount));
            builderProgress.AppendLine(string.Format("{0}", analyzer.WrongLines));
            builderProgress.Append(string.Format("{0}", analyzer.Errors));

            FinishMenu.txbProgress.Text = builderProgress.ToString();
        }

        private void ClearGridView()
        {
            grdTableLines.Rows.Clear();
            grdTableLines.Columns.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (importer != null)
                importer.Stop();
        }
    }
}

