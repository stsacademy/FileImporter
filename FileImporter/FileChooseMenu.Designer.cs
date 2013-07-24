namespace FilesImporter
{
    partial class FileChooseMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowseFolderPath = new System.Windows.Forms.Button();
            this.btnBrowseDbDir = new System.Windows.Forms.Button();
            this.txtDbDir = new System.Windows.Forms.TextBox();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxFolderFiles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLinesToRead = new System.Windows.Forms.ComboBox();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.chkCompressedFiles = new System.Windows.Forms.CheckBox();
            this.cmbMask = new System.Windows.Forms.ComboBox();
            this.cmbSkipLines = new System.Windows.Forms.ComboBox();
            this.grpFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseFolderPath
            // 
            this.btnBrowseFolderPath.Location = new System.Drawing.Point(438, 86);
            this.btnBrowseFolderPath.Name = "btnBrowseFolderPath";
            this.btnBrowseFolderPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFolderPath.TabIndex = 0;
            this.btnBrowseFolderPath.Text = "Browse...";
            this.btnBrowseFolderPath.UseVisualStyleBackColor = true;
            // 
            // btnBrowseDbDir
            // 
            this.btnBrowseDbDir.Location = new System.Drawing.Point(438, 45);
            this.btnBrowseDbDir.Name = "btnBrowseDbDir";
            this.btnBrowseDbDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDbDir.TabIndex = 1;
            this.btnBrowseDbDir.Text = "Browse...";
            this.btnBrowseDbDir.UseVisualStyleBackColor = true;
            // 
            // txtDbDir
            // 
            this.txtDbDir.BackColor = System.Drawing.SystemColors.Window;
            this.txtDbDir.Location = new System.Drawing.Point(22, 47);
            this.txtDbDir.Name = "txtDbDir";
            this.txtDbDir.ReadOnly = true;
            this.txtDbDir.Size = new System.Drawing.Size(410, 20);
            this.txtDbDir.TabIndex = 2;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.AccessibleName = "";
            this.txtFolderPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtFolderPath.Location = new System.Drawing.Point(22, 86);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(410, 20);
            this.txtFolderPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Skip Lines:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mask:";
            // 
            // lbxFolderFiles
            // 
            this.lbxFolderFiles.Enabled = false;
            this.lbxFolderFiles.FormattingEnabled = true;
            this.lbxFolderFiles.Location = new System.Drawing.Point(6, 22);
            this.lbxFolderFiles.Name = "lbxFolderFiles";
            this.lbxFolderFiles.Size = new System.Drawing.Size(477, 69);
            this.lbxFolderFiles.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Folder Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database Directory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lines to read:";
            // 
            // cmbLinesToRead
            // 
            this.cmbLinesToRead.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLinesToRead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinesToRead.FormattingEnabled = true;
            this.cmbLinesToRead.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22"});
            this.cmbLinesToRead.Location = new System.Drawing.Point(255, 116);
            this.cmbLinesToRead.Name = "cmbLinesToRead";
            this.cmbLinesToRead.Size = new System.Drawing.Size(53, 21);
            this.cmbLinesToRead.TabIndex = 13;
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.lbxFolderFiles);
            this.grpFiles.Location = new System.Drawing.Point(22, 178);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(489, 107);
            this.grpFiles.TabIndex = 14;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files in folder:";
            // 
            // chkCompressedFiles
            // 
            this.chkCompressedFiles.AutoSize = true;
            this.chkCompressedFiles.Location = new System.Drawing.Point(22, 116);
            this.chkCompressedFiles.Name = "chkCompressedFiles";
            this.chkCompressedFiles.Size = new System.Drawing.Size(108, 17);
            this.chkCompressedFiles.TabIndex = 15;
            this.chkCompressedFiles.Text = "Compressed Files";
            this.chkCompressedFiles.UseVisualStyleBackColor = true;
            // 
            // cmbMask
            // 
            this.cmbMask.AutoCompleteCustomSource.AddRange(new string[] {
            "*.txt",
            "*.*"});
            this.cmbMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMask.FormattingEnabled = true;
            this.cmbMask.Items.AddRange(new object[] {
            "*.txt",
            "*.epf",
            "*.*"});
            this.cmbMask.Location = new System.Drawing.Point(61, 142);
            this.cmbMask.Name = "cmbMask";
            this.cmbMask.Size = new System.Drawing.Size(53, 21);
            this.cmbMask.TabIndex = 16;
            // 
            // cmbSkipLines
            // 
            this.cmbSkipLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkipLines.FormattingEnabled = true;
            this.cmbSkipLines.Items.AddRange(new object[] {
            "0",
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.cmbSkipLines.Location = new System.Drawing.Point(255, 142);
            this.cmbSkipLines.Name = "cmbSkipLines";
            this.cmbSkipLines.Size = new System.Drawing.Size(53, 21);
            this.cmbSkipLines.TabIndex = 17;
            // 
            // FileChooseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSkipLines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLinesToRead);
            this.Controls.Add(this.cmbMask);
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseDbDir);
            this.Controls.Add(this.txtDbDir);
            this.Controls.Add(this.chkCompressedFiles);
            this.Controls.Add(this.btnBrowseFolderPath);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "FileChooseMenu";
            this.Size = new System.Drawing.Size(560, 320);
            this.grpFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnBrowseFolderPath;
        internal System.Windows.Forms.TextBox txtDbDir;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtFolderPath;
        internal System.Windows.Forms.ListBox lbxFolderFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbLinesToRead;
        internal System.Windows.Forms.CheckBox chkCompressedFiles;
        internal System.Windows.Forms.ComboBox cmbMask;
        internal System.Windows.Forms.Button btnBrowseDbDir;
        internal System.Windows.Forms.GroupBox grpFiles;
        internal System.Windows.Forms.ComboBox cmbSkipLines;
    }
}
