namespace FilesImporter
{
    partial class DelimiterChooseMenu
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
            this.chkDelimiterComma = new System.Windows.Forms.CheckBox();
            this.chkDelimiterSemicolon = new System.Windows.Forms.CheckBox();
            this.chkDelimiterOther = new System.Windows.Forms.CheckBox();
            this.txbDelimiterOther = new System.Windows.Forms.TextBox();
            this.grpDelimiters = new System.Windows.Forms.GroupBox();
            this.cmbDecimalSeparator = new System.Windows.Forms.ComboBox();
            this.lblDecimalSeparator = new System.Windows.Forms.Label();
            this.cmbShortDate = new System.Windows.Forms.ComboBox();
            this.lblShortDate = new System.Windows.Forms.Label();
            this.grpSplitOptions = new System.Windows.Forms.GroupBox();
            this.rbtnNaNSplitOption = new System.Windows.Forms.RadioButton();
            this.rbtnRemoveEmptyEntriesSplitOption = new System.Windows.Forms.RadioButton();
            this.grpDateTime = new System.Windows.Forms.GroupBox();
            this.cmbShortTime = new System.Windows.Forms.ComboBox();
            this.cmbLongTime = new System.Windows.Forms.ComboBox();
            this.lblLongTime = new System.Windows.Forms.Label();
            this.lblShortTime = new System.Windows.Forms.Label();
            this.cmbLongDate = new System.Windows.Forms.ComboBox();
            this.lblLongDate = new System.Windows.Forms.Label();
            this.grpDelimiters.SuspendLayout();
            this.grpSplitOptions.SuspendLayout();
            this.grpDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkDelimiterComma
            // 
            this.chkDelimiterComma.AutoSize = true;
            this.chkDelimiterComma.Location = new System.Drawing.Point(6, 39);
            this.chkDelimiterComma.Name = "chkDelimiterComma";
            this.chkDelimiterComma.Size = new System.Drawing.Size(61, 17);
            this.chkDelimiterComma.TabIndex = 0;
            this.chkDelimiterComma.Text = "Comma";
            this.chkDelimiterComma.UseVisualStyleBackColor = true;
            // 
            // chkDelimiterSemicolon
            // 
            this.chkDelimiterSemicolon.AutoSize = true;
            this.chkDelimiterSemicolon.Location = new System.Drawing.Point(6, 62);
            this.chkDelimiterSemicolon.Name = "chkDelimiterSemicolon";
            this.chkDelimiterSemicolon.Size = new System.Drawing.Size(75, 17);
            this.chkDelimiterSemicolon.TabIndex = 1;
            this.chkDelimiterSemicolon.Text = "Semicolon";
            this.chkDelimiterSemicolon.UseVisualStyleBackColor = true;
            // 
            // chkDelimiterOther
            // 
            this.chkDelimiterOther.AutoSize = true;
            this.chkDelimiterOther.Enabled = false;
            this.chkDelimiterOther.Location = new System.Drawing.Point(6, 85);
            this.chkDelimiterOther.Name = "chkDelimiterOther";
            this.chkDelimiterOther.Size = new System.Drawing.Size(52, 17);
            this.chkDelimiterOther.TabIndex = 2;
            this.chkDelimiterOther.Text = "Other";
            this.chkDelimiterOther.UseVisualStyleBackColor = true;
            // 
            // txbDelimiterOther
            // 
            this.txbDelimiterOther.Location = new System.Drawing.Point(71, 82);
            this.txbDelimiterOther.MaxLength = 1;
            this.txbDelimiterOther.Name = "txbDelimiterOther";
            this.txbDelimiterOther.Size = new System.Drawing.Size(27, 20);
            this.txbDelimiterOther.TabIndex = 3;
            this.txbDelimiterOther.TextChanged += new System.EventHandler(this.txbDelimiterOther_TextChanged);
            // 
            // grpDelimiters
            // 
            this.grpDelimiters.Controls.Add(this.chkDelimiterComma);
            this.grpDelimiters.Controls.Add(this.txbDelimiterOther);
            this.grpDelimiters.Controls.Add(this.chkDelimiterSemicolon);
            this.grpDelimiters.Controls.Add(this.chkDelimiterOther);
            this.grpDelimiters.Location = new System.Drawing.Point(22, 30);
            this.grpDelimiters.Name = "grpDelimiters";
            this.grpDelimiters.Size = new System.Drawing.Size(144, 115);
            this.grpDelimiters.TabIndex = 4;
            this.grpDelimiters.TabStop = false;
            this.grpDelimiters.Text = "Delimiters";
            // 
            // cmbDecimalSeparator
            // 
            this.cmbDecimalSeparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecimalSeparator.FormattingEnabled = true;
            this.cmbDecimalSeparator.Items.AddRange(new object[] {
            ",",
            "."});
            this.cmbDecimalSeparator.Location = new System.Drawing.Point(343, 192);
            this.cmbDecimalSeparator.Name = "cmbDecimalSeparator";
            this.cmbDecimalSeparator.Size = new System.Drawing.Size(121, 21);
            this.cmbDecimalSeparator.TabIndex = 5;
            // 
            // lblDecimalSeparator
            // 
            this.lblDecimalSeparator.AutoSize = true;
            this.lblDecimalSeparator.Location = new System.Drawing.Point(189, 195);
            this.lblDecimalSeparator.Name = "lblDecimalSeparator";
            this.lblDecimalSeparator.Size = new System.Drawing.Size(133, 13);
            this.lblDecimalSeparator.TabIndex = 6;
            this.lblDecimalSeparator.Text = "Number decimal separator:";
            // 
            // cmbShortDate
            // 
            this.cmbShortDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShortDate.FormattingEnabled = true;
            this.cmbShortDate.Items.AddRange(new object[] {
            "M/d/yy",
            "M/d/yyyy",
            "MM/dd/yy",
            "MM/dd/yyyy",
            "yy/MM/dd",
            "yyyy-MM-dd",
            "dd-MMM-yy"});
            this.cmbShortDate.Location = new System.Drawing.Point(151, 22);
            this.cmbShortDate.Name = "cmbShortDate";
            this.cmbShortDate.Size = new System.Drawing.Size(121, 21);
            this.cmbShortDate.TabIndex = 7;
            // 
            // lblShortDate
            // 
            this.lblShortDate.AutoSize = true;
            this.lblShortDate.Location = new System.Drawing.Point(11, 25);
            this.lblShortDate.Name = "lblShortDate";
            this.lblShortDate.Size = new System.Drawing.Size(59, 13);
            this.lblShortDate.TabIndex = 8;
            this.lblShortDate.Text = "Short date:";
            // 
            // grpSplitOptions
            // 
            this.grpSplitOptions.Controls.Add(this.rbtnNaNSplitOption);
            this.grpSplitOptions.Controls.Add(this.rbtnRemoveEmptyEntriesSplitOption);
            this.grpSplitOptions.Location = new System.Drawing.Point(22, 149);
            this.grpSplitOptions.Name = "grpSplitOptions";
            this.grpSplitOptions.Size = new System.Drawing.Size(144, 71);
            this.grpSplitOptions.TabIndex = 9;
            this.grpSplitOptions.TabStop = false;
            this.grpSplitOptions.Text = "Split options:";
            // 
            // rbtnNaNSplitOption
            // 
            this.rbtnNaNSplitOption.AutoSize = true;
            this.rbtnNaNSplitOption.Checked = true;
            this.rbtnNaNSplitOption.Location = new System.Drawing.Point(6, 19);
            this.rbtnNaNSplitOption.Name = "rbtnNaNSplitOption";
            this.rbtnNaNSplitOption.Size = new System.Drawing.Size(47, 17);
            this.rbtnNaNSplitOption.TabIndex = 10;
            this.rbtnNaNSplitOption.TabStop = true;
            this.rbtnNaNSplitOption.Text = "NaN";
            this.rbtnNaNSplitOption.UseVisualStyleBackColor = true;
            // 
            // rbtnRemoveEmptyEntriesSplitOption
            // 
            this.rbtnRemoveEmptyEntriesSplitOption.AutoSize = true;
            this.rbtnRemoveEmptyEntriesSplitOption.Location = new System.Drawing.Point(6, 42);
            this.rbtnRemoveEmptyEntriesSplitOption.Name = "rbtnRemoveEmptyEntriesSplitOption";
            this.rbtnRemoveEmptyEntriesSplitOption.Size = new System.Drawing.Size(130, 17);
            this.rbtnRemoveEmptyEntriesSplitOption.TabIndex = 11;
            this.rbtnRemoveEmptyEntriesSplitOption.Text = "Remove empty entries";
            this.rbtnRemoveEmptyEntriesSplitOption.UseVisualStyleBackColor = true;
            // 
            // grpDateTime
            // 
            this.grpDateTime.Controls.Add(this.cmbShortTime);
            this.grpDateTime.Controls.Add(this.cmbLongTime);
            this.grpDateTime.Controls.Add(this.lblLongTime);
            this.grpDateTime.Controls.Add(this.lblShortTime);
            this.grpDateTime.Controls.Add(this.cmbLongDate);
            this.grpDateTime.Controls.Add(this.lblLongDate);
            this.grpDateTime.Controls.Add(this.cmbShortDate);
            this.grpDateTime.Controls.Add(this.lblShortDate);
            this.grpDateTime.Location = new System.Drawing.Point(192, 30);
            this.grpDateTime.Name = "grpDateTime";
            this.grpDateTime.Size = new System.Drawing.Size(287, 143);
            this.grpDateTime.TabIndex = 10;
            this.grpDateTime.TabStop = false;
            this.grpDateTime.Text = "Date and time format:";
            // 
            // cmbShortTime
            // 
            this.cmbShortTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShortTime.FormattingEnabled = true;
            this.cmbShortTime.Items.AddRange(new object[] {
            "h:mm tt",
            "hh:mm tt",
            "H:mm",
            "HH:mm"});
            this.cmbShortTime.Location = new System.Drawing.Point(151, 76);
            this.cmbShortTime.Name = "cmbShortTime";
            this.cmbShortTime.Size = new System.Drawing.Size(121, 21);
            this.cmbShortTime.TabIndex = 14;
            // 
            // cmbLongTime
            // 
            this.cmbLongTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLongTime.FormattingEnabled = true;
            this.cmbLongTime.Items.AddRange(new object[] {
            "h:mm:ss tt",
            "hh:mm:ss tt",
            "H:mm:ss",
            "HH:mm:ss"});
            this.cmbLongTime.Location = new System.Drawing.Point(151, 103);
            this.cmbLongTime.Name = "cmbLongTime";
            this.cmbLongTime.Size = new System.Drawing.Size(121, 21);
            this.cmbLongTime.TabIndex = 13;
            // 
            // lblLongTime
            // 
            this.lblLongTime.AutoSize = true;
            this.lblLongTime.Location = new System.Drawing.Point(11, 106);
            this.lblLongTime.Name = "lblLongTime";
            this.lblLongTime.Size = new System.Drawing.Size(56, 13);
            this.lblLongTime.TabIndex = 12;
            this.lblLongTime.Text = "Long time:";
            // 
            // lblShortTime
            // 
            this.lblShortTime.AutoSize = true;
            this.lblShortTime.Location = new System.Drawing.Point(11, 79);
            this.lblShortTime.Name = "lblShortTime";
            this.lblShortTime.Size = new System.Drawing.Size(57, 13);
            this.lblShortTime.TabIndex = 11;
            this.lblShortTime.Text = "Short time:";
            // 
            // cmbLongDate
            // 
            this.cmbLongDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLongDate.FormattingEnabled = true;
            this.cmbLongDate.Items.AddRange(new object[] {
            "dddd, MMMM d, yyyy",
            "MMMM d, yyyy",
            "dddd, d MMMM, yyyy",
            "d MMMM, yyyy"});
            this.cmbLongDate.Location = new System.Drawing.Point(151, 49);
            this.cmbLongDate.Name = "cmbLongDate";
            this.cmbLongDate.Size = new System.Drawing.Size(121, 21);
            this.cmbLongDate.TabIndex = 10;
            // 
            // lblLongDate
            // 
            this.lblLongDate.AutoSize = true;
            this.lblLongDate.Location = new System.Drawing.Point(11, 52);
            this.lblLongDate.Name = "lblLongDate";
            this.lblLongDate.Size = new System.Drawing.Size(58, 13);
            this.lblLongDate.TabIndex = 9;
            this.lblLongDate.Text = "Long date:";
            // 
            // DelimiterChooseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDateTime);
            this.Controls.Add(this.grpSplitOptions);
            this.Controls.Add(this.lblDecimalSeparator);
            this.Controls.Add(this.cmbDecimalSeparator);
            this.Controls.Add(this.grpDelimiters);
            this.Name = "DelimiterChooseMenu";
            this.Size = new System.Drawing.Size(560, 320);
            this.grpDelimiters.ResumeLayout(false);
            this.grpDelimiters.PerformLayout();
            this.grpSplitOptions.ResumeLayout(false);
            this.grpSplitOptions.PerformLayout();
            this.grpDateTime.ResumeLayout(false);
            this.grpDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkDelimiterComma;
        internal System.Windows.Forms.CheckBox chkDelimiterSemicolon;
        internal System.Windows.Forms.CheckBox chkDelimiterOther;
        internal System.Windows.Forms.TextBox txbDelimiterOther;
        private System.Windows.Forms.GroupBox grpDelimiters;
        private System.Windows.Forms.Label lblDecimalSeparator;
        internal System.Windows.Forms.ComboBox cmbDecimalSeparator;
        internal System.Windows.Forms.ComboBox cmbShortDate;
        private System.Windows.Forms.Label lblShortDate;
        private System.Windows.Forms.GroupBox grpSplitOptions;
        internal System.Windows.Forms.RadioButton rbtnNaNSplitOption;
        internal System.Windows.Forms.RadioButton rbtnRemoveEmptyEntriesSplitOption;
        private System.Windows.Forms.GroupBox grpDateTime;
        private System.Windows.Forms.Label lblLongDate;
        internal System.Windows.Forms.ComboBox cmbLongDate;
        internal System.Windows.Forms.ComboBox cmbShortTime;
        internal System.Windows.Forms.ComboBox cmbLongTime;
        private System.Windows.Forms.Label lblLongTime;
        private System.Windows.Forms.Label lblShortTime;

    }
}
