namespace WindowsFormsApp4
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
            this.cmbGunler = new System.Windows.Forms.ComboBox();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbEkle = new System.Windows.Forms.ComboBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGunler
            // 
            this.cmbGunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbGunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGunler.FormattingEnabled = true;
            this.cmbGunler.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma"});
            this.cmbGunler.Location = new System.Drawing.Point(12, 12);
            this.cmbGunler.Name = "cmbGunler";
            this.cmbGunler.Size = new System.Drawing.Size(347, 39);
            this.cmbGunler.TabIndex = 0;
            this.cmbGunler.SelectedIndexChanged += new System.EventHandler(this.cmbGunler_SelectedIndexChanged);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.Location = new System.Drawing.Point(374, 13);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(354, 38);
            this.btnRandevu.TabIndex = 1;
            this.btnRandevu.Text = "Randevularımı Getir";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(374, 361);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(354, 38);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbEkle
            // 
            this.cmbEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEkle.FormattingEnabled = true;
            this.cmbEkle.Location = new System.Drawing.Point(12, 304);
            this.cmbEkle.Name = "cmbEkle";
            this.cmbEkle.Size = new System.Drawing.Size(347, 39);
            this.cmbEkle.TabIndex = 2;
            this.cmbEkle.SelectedIndexChanged += new System.EventHandler(this.cmbEkle_SelectedIndexChanged);
            // 
            // txtEkle
            // 
            this.txtEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtEkle.Location = new System.Drawing.Point(374, 304);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(354, 38);
            this.txtEkle.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button1.Location = new System.Drawing.Point(374, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbEkle);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.cmbGunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGunler;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button button1;
    }
}

