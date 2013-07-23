namespace FilesImporter
{
    partial class FinishMenu
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
            this.txbSettings = new System.Windows.Forms.TextBox();
            this.txbProgress = new System.Windows.Forms.TextBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.lblCompressedFiles = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.lblSkipLines = new System.Windows.Forms.Label();
            this.lblDelimiters = new System.Windows.Forms.Label();
            this.grpProgress = new System.Windows.Forms.GroupBox();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblErrorFiles = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblWrongLines = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.grpProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSettings
            // 
            this.txbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSettings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbSettings.Location = new System.Drawing.Point(138, 27);
            this.txbSettings.Multiline = true;
            this.txbSettings.Name = "txbSettings";
            this.txbSettings.ReadOnly = true;
            this.txbSettings.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbSettings.Size = new System.Drawing.Size(388, 148);
            this.txbSettings.TabIndex = 0;
            // 
            // txbProgress
            // 
            this.txbProgress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbProgress.Location = new System.Drawing.Point(88, 37);
            this.txbProgress.Multiline = true;
            this.txbProgress.Name = "txbProgress";
            this.txbProgress.ReadOnly = true;
            this.txbProgress.Size = new System.Drawing.Size(72, 81);
            this.txbProgress.TabIndex = 3;
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.txbSettings);
            this.grpSettings.Controls.Add(this.lblCompressedFiles);
            this.grpSettings.Controls.Add(this.lblMask);
            this.grpSettings.Controls.Add(this.lblFolderPath);
            this.grpSettings.Controls.Add(this.lblTypes);
            this.grpSettings.Controls.Add(this.lblDirectory);
            this.grpSettings.Controls.Add(this.lblSkipLines);
            this.grpSettings.Controls.Add(this.lblDelimiters);
            this.grpSettings.Location = new System.Drawing.Point(25, 37);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(531, 181);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings:";
            // 
            // lblCompressedFiles
            // 
            this.lblCompressedFiles.AutoSize = true;
            this.lblCompressedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompressedFiles.Location = new System.Drawing.Point(16, 57);
            this.lblCompressedFiles.Name = "lblCompressedFiles";
            this.lblCompressedFiles.Size = new System.Drawing.Size(105, 15);
            this.lblCompressedFiles.TabIndex = 3;
            this.lblCompressedFiles.Text = "Compressed files:";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMask.Location = new System.Drawing.Point(16, 87);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(40, 15);
            this.lblMask.TabIndex = 5;
            this.lblMask.Text = "Mask:";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFolderPath.Location = new System.Drawing.Point(16, 42);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(72, 15);
            this.lblFolderPath.TabIndex = 2;
            this.lblFolderPath.Text = "Folder path:";
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypes.Location = new System.Drawing.Point(16, 117);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(84, 15);
            this.lblTypes.TabIndex = 7;
            this.lblTypes.Text = "Column types:";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDirectory.Location = new System.Drawing.Point(16, 27);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(116, 15);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Data Base directory:";
            // 
            // lblSkipLines
            // 
            this.lblSkipLines.AutoSize = true;
            this.lblSkipLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkipLines.Location = new System.Drawing.Point(16, 72);
            this.lblSkipLines.Name = "lblSkipLines";
            this.lblSkipLines.Size = new System.Drawing.Size(63, 15);
            this.lblSkipLines.TabIndex = 4;
            this.lblSkipLines.Text = "Skip lines:";
            // 
            // lblDelimiters
            // 
            this.lblDelimiters.AutoSize = true;
            this.lblDelimiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDelimiters.Location = new System.Drawing.Point(16, 102);
            this.lblDelimiters.Name = "lblDelimiters";
            this.lblDelimiters.Size = new System.Drawing.Size(66, 15);
            this.lblDelimiters.TabIndex = 6;
            this.lblDelimiters.Text = "Delimiters:";
            // 
            // grpProgress
            // 
            this.grpProgress.Controls.Add(this.txbProgress);
            this.grpProgress.Controls.Add(this.lblLines);
            this.grpProgress.Controls.Add(this.lblErrorFiles);
            this.grpProgress.Controls.Add(this.lblFiles);
            this.grpProgress.Controls.Add(this.lblWrongLines);
            this.grpProgress.Controls.Add(this.lblSize);
            this.grpProgress.Location = new System.Drawing.Point(25, 232);
            this.grpProgress.Name = "grpProgress";
            this.grpProgress.Size = new System.Drawing.Size(211, 127);
            this.grpProgress.TabIndex = 5;
            this.grpProgress.TabStop = false;
            this.grpProgress.Text = "Progress:";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLines.Location = new System.Drawing.Point(16, 65);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(40, 15);
            this.lblLines.TabIndex = 8;
            this.lblLines.Text = "Lines:";
            // 
            // lblErrorFiles
            // 
            this.lblErrorFiles.AutoSize = true;
            this.lblErrorFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorFiles.Location = new System.Drawing.Point(16, 95);
            this.lblErrorFiles.Name = "lblErrorFiles";
            this.lblErrorFiles.Size = new System.Drawing.Size(62, 15);
            this.lblErrorFiles.TabIndex = 10;
            this.lblErrorFiles.Text = "Error files:";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFiles.Location = new System.Drawing.Point(16, 37);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(70, 15);
            this.lblFiles.TabIndex = 6;
            this.lblFiles.Text = "Import files:";
            // 
            // lblWrongLines
            // 
            this.lblWrongLines.AutoSize = true;
            this.lblWrongLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWrongLines.Location = new System.Drawing.Point(16, 80);
            this.lblWrongLines.Name = "lblWrongLines";
            this.lblWrongLines.Size = new System.Drawing.Size(75, 15);
            this.lblWrongLines.TabIndex = 9;
            this.lblWrongLines.Text = "Wrong lines:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSize.Location = new System.Drawing.Point(16, 51);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 15);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "Size:";
            // 
            // FinishMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpProgress);
            this.Controls.Add(this.grpSettings);
            this.Name = "FinishMenu";
            this.Size = new System.Drawing.Size(680, 362);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpProgress.ResumeLayout(false);
            this.grpProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txbSettings;
        internal System.Windows.Forms.TextBox txbProgress;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox grpProgress;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblWrongLines;
        private System.Windows.Forms.Label lblErrorFiles;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.Label lblDelimiters;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblSkipLines;
        private System.Windows.Forms.Label lblCompressedFiles;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Label lblDirectory;
    }
}
