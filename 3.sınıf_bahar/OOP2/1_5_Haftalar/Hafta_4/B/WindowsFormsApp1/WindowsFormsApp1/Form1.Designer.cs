namespace WindowsFormsApp1
{
    partial class myForm
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
            this.btnMesajKutusu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesajKutusu
            // 
            this.btnMesajKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajKutusu.Location = new System.Drawing.Point(213, 12);
            this.btnMesajKutusu.Name = "btnMesajKutusu";
            this.btnMesajKutusu.Size = new System.Drawing.Size(369, 51);
            this.btnMesajKutusu.TabIndex = 0;
            this.btnMesajKutusu.Text = "Basit Mesaj Kutusu";
            this.btnMesajKutusu.UseVisualStyleBackColor = true;
            this.btnMesajKutusu.Click += new System.EventHandler(this.btnMesajKutusu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(213, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cevap Mesaj Kutusu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkran.Location = new System.Drawing.Point(213, 168);
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(369, 38);
            this.txtEkran.TabIndex = 2;
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFontDialog.Location = new System.Drawing.Point(213, 246);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(369, 51);
            this.btnFontDialog.TabIndex = 3;
            this.btnFontDialog.Text = "Font Dialog Kutusu";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMesajKutusu);
            this.Name = "myForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMesajKutusu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnFontDialog;
    }
}

