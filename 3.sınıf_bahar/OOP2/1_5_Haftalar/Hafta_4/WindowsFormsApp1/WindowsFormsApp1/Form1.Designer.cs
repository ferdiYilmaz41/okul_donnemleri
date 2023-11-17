namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnSimpleMsg = new System.Windows.Forms.Button();
            this.btnMsgDlg = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimpleMsg
            // 
            this.btnSimpleMsg.Location = new System.Drawing.Point(129, 10);
            this.btnSimpleMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimpleMsg.Name = "btnSimpleMsg";
            this.btnSimpleMsg.Size = new System.Drawing.Size(141, 22);
            this.btnSimpleMsg.TabIndex = 0;
            this.btnSimpleMsg.Text = "Mesaj Kutusu";
            this.btnSimpleMsg.UseVisualStyleBackColor = true;
            this.btnSimpleMsg.Click += new System.EventHandler(this.btnSimpleMsg_Click);
            // 
            // btnMsgDlg
            // 
            this.btnMsgDlg.Location = new System.Drawing.Point(129, 37);
            this.btnMsgDlg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMsgDlg.Name = "btnMsgDlg";
            this.btnMsgDlg.Size = new System.Drawing.Size(141, 22);
            this.btnMsgDlg.TabIndex = 1;
            this.btnMsgDlg.Text = "Mesaj Kutusu Dialog";
            this.btnMsgDlg.UseVisualStyleBackColor = true;
            this.btnMsgDlg.Click += new System.EventHandler(this.btnMsgDlg_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.Location = new System.Drawing.Point(129, 88);
            this.lbSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 26);
            this.lbSonuc.TabIndex = 2;
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(129, 154);
            this.btnFontDialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(141, 22);
            this.btnFontDialog.TabIndex = 3;
            this.btnFontDialog.Text = "Font Kutusu Dialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btnMsgDlg);
            this.Controls.Add(this.btnSimpleMsg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleMsg;
        private System.Windows.Forms.Button btnMsgDlg;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.Button btnFontDialog;
    }
}

