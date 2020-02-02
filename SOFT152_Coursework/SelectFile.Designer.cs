namespace SOFT152_Coursework
{
    partial class SelectFile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgressBarValidity = new System.Windows.Forms.ProgressBar();
            this.btnConfirmFile = new System.Windows.Forms.Button();
            this.lstboxDisplay = new System.Windows.Forms.ListBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblFirst40itms = new System.Windows.Forms.Label();
            this.lblFileStatsHeader = new System.Windows.Forms.Label();
            this.lblFileLengthHeader = new System.Windows.Forms.Label();
            this.lblFileSizeHeader = new System.Windows.Forms.Label();
            this.lblFilePathHeader = new System.Windows.Forms.Label();
            this.lblFileNameHeader = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFileLen = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBarValidity
            // 
            this.ProgressBarValidity.Location = new System.Drawing.Point(106, 202);
            this.ProgressBarValidity.Name = "ProgressBarValidity";
            this.ProgressBarValidity.Size = new System.Drawing.Size(294, 23);
            this.ProgressBarValidity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarValidity.TabIndex = 12;
            // 
            // btnConfirmFile
            // 
            this.btnConfirmFile.Location = new System.Drawing.Point(10, 67);
            this.btnConfirmFile.Name = "btnConfirmFile";
            this.btnConfirmFile.Size = new System.Drawing.Size(77, 33);
            this.btnConfirmFile.TabIndex = 11;
            this.btnConfirmFile.Text = "Confirm File";
            this.btnConfirmFile.UseVisualStyleBackColor = true;
            this.btnConfirmFile.Click += new System.EventHandler(this.BtnConfirmFile_Click);
            // 
            // lstboxDisplay
            // 
            this.lstboxDisplay.FormattingEnabled = true;
            this.lstboxDisplay.HorizontalScrollbar = true;
            this.lstboxDisplay.Items.AddRange(new object[] {
            "No file selected"});
            this.lstboxDisplay.Location = new System.Drawing.Point(106, 26);
            this.lstboxDisplay.Name = "lstboxDisplay";
            this.lstboxDisplay.Size = new System.Drawing.Size(295, 160);
            this.lstboxDisplay.TabIndex = 10;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(10, 26);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(77, 32);
            this.btnSelectFile.TabIndex = 9;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // lblFirst40itms
            // 
            this.lblFirst40itms.AutoSize = true;
            this.lblFirst40itms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst40itms.Location = new System.Drawing.Point(104, 8);
            this.lblFirst40itms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirst40itms.Name = "lblFirst40itms";
            this.lblFirst40itms.Size = new System.Drawing.Size(138, 15);
            this.lblFirst40itms.TabIndex = 13;
            this.lblFirst40itms.Text = "First 40 items in file:";
            // 
            // lblFileStatsHeader
            // 
            this.lblFileStatsHeader.AutoSize = true;
            this.lblFileStatsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileStatsHeader.Location = new System.Drawing.Point(8, 232);
            this.lblFileStatsHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileStatsHeader.Name = "lblFileStatsHeader";
            this.lblFileStatsHeader.Size = new System.Drawing.Size(79, 17);
            this.lblFileStatsHeader.TabIndex = 14;
            this.lblFileStatsHeader.Text = "File stats:";
            // 
            // lblFileLengthHeader
            // 
            this.lblFileLengthHeader.AutoSize = true;
            this.lblFileLengthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLengthHeader.Location = new System.Drawing.Point(9, 280);
            this.lblFileLengthHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileLengthHeader.Name = "lblFileLengthHeader";
            this.lblFileLengthHeader.Size = new System.Drawing.Size(79, 15);
            this.lblFileLengthHeader.TabIndex = 15;
            this.lblFileLengthHeader.Text = "File length:";
            // 
            // lblFileSizeHeader
            // 
            this.lblFileSizeHeader.AutoSize = true;
            this.lblFileSizeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSizeHeader.Location = new System.Drawing.Point(9, 304);
            this.lblFileSizeHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileSizeHeader.Name = "lblFileSizeHeader";
            this.lblFileSizeHeader.Size = new System.Drawing.Size(65, 15);
            this.lblFileSizeHeader.TabIndex = 16;
            this.lblFileSizeHeader.Text = "File size:";
            // 
            // lblFilePathHeader
            // 
            this.lblFilePathHeader.AutoSize = true;
            this.lblFilePathHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePathHeader.Location = new System.Drawing.Point(9, 327);
            this.lblFilePathHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilePathHeader.Name = "lblFilePathHeader";
            this.lblFilePathHeader.Size = new System.Drawing.Size(64, 15);
            this.lblFilePathHeader.TabIndex = 17;
            this.lblFilePathHeader.Text = "File Path";
            // 
            // lblFileNameHeader
            // 
            this.lblFileNameHeader.AutoSize = true;
            this.lblFileNameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNameHeader.Location = new System.Drawing.Point(9, 256);
            this.lblFileNameHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileNameHeader.Name = "lblFileNameHeader";
            this.lblFileNameHeader.Size = new System.Drawing.Size(75, 15);
            this.lblFileNameHeader.TabIndex = 18;
            this.lblFileNameHeader.Text = "File name:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(95, 256);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(91, 15);
            this.lblFileName.TabIndex = 19;
            this.lblFileName.Text = "No file selected";
            // 
            // lblFileLen
            // 
            this.lblFileLen.AutoSize = true;
            this.lblFileLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLen.Location = new System.Drawing.Point(95, 280);
            this.lblFileLen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileLen.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblFileLen.Name = "lblFileLen";
            this.lblFileLen.Size = new System.Drawing.Size(91, 15);
            this.lblFileLen.TabIndex = 20;
            this.lblFileLen.Text = "No file selected";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.Location = new System.Drawing.Point(95, 304);
            this.lblFileSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileSize.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(91, 15);
            this.lblFileSize.TabIndex = 21;
            this.lblFileSize.Text = "No file selected";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(95, 327);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilePath.MaximumSize = new System.Drawing.Size(330, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(91, 15);
            this.lblFilePath.TabIndex = 22;
            this.lblFilePath.Text = "No file selected";
            // 
            // SelectFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 385);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblFileLen);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblFileNameHeader);
            this.Controls.Add(this.lblFilePathHeader);
            this.Controls.Add(this.lblFileSizeHeader);
            this.Controls.Add(this.lblFileLengthHeader);
            this.Controls.Add(this.lblFileStatsHeader);
            this.Controls.Add(this.lblFirst40itms);
            this.Controls.Add(this.ProgressBarValidity);
            this.Controls.Add(this.btnConfirmFile);
            this.Controls.Add(this.lstboxDisplay);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SelectFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarValidity;
        private System.Windows.Forms.Button btnConfirmFile;
        private System.Windows.Forms.ListBox lstboxDisplay;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblFirst40itms;
        private System.Windows.Forms.Label lblFileStatsHeader;
        private System.Windows.Forms.Label lblFileLengthHeader;
        private System.Windows.Forms.Label lblFileSizeHeader;
        private System.Windows.Forms.Label lblFilePathHeader;
        private System.Windows.Forms.Label lblFileNameHeader;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileLen;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFilePath;
    }
}