namespace SOFT152_Coursework
{
    partial class InputDialog
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
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMsgText = new System.Windows.Forms.Label();
            this.TxtInputBox = new System.Windows.Forms.TextBox();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.Location = new System.Drawing.Point(20, 85);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(113, 27);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(180, 85);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMsgText
            // 
            this.lblMsgText.AutoSize = true;
            this.lblMsgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgText.Location = new System.Drawing.Point(16, 5);
            this.lblMsgText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgText.MaximumSize = new System.Drawing.Size(267, 0);
            this.lblMsgText.Name = "lblMsgText";
            this.lblMsgText.Size = new System.Drawing.Size(78, 20);
            this.lblMsgText.TabIndex = 2;
            this.lblMsgText.Text = "FillerText";
            // 
            // TxtInputBox
            // 
            this.TxtInputBox.Location = new System.Drawing.Point(20, 53);
            this.TxtInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtInputBox.Name = "TxtInputBox";
            this.TxtInputBox.ShortcutsEnabled = false;
            this.TxtInputBox.Size = new System.Drawing.Size(259, 22);
            this.TxtInputBox.TabIndex = 4;
            this.TxtInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInputBox_KeyDown);
            this.TxtInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYearInput_KeyPress);
            // 
            // BtnMax
            // 
            this.BtnMax.Location = new System.Drawing.Point(141, 26);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(49, 23);
            this.BtnMax.TabIndex = 5;
            this.BtnMax.Text = "Max";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Visible = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Location = new System.Drawing.Point(84, 26);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(49, 23);
            this.BtnMin.TabIndex = 6;
            this.BtnMin.Text = "Min";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Visible = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 117);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnMax);
            this.Controls.Add(this.TxtInputBox);
            this.Controls.Add(this.lblMsgText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Year";
            this.Load += new System.EventHandler(this.InputDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMsgText;
        private System.Windows.Forms.TextBox TxtInputBox;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnMin;
    }
}