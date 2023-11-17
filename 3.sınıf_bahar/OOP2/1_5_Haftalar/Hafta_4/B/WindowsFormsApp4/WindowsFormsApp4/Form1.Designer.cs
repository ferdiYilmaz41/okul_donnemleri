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
            this.btnSecim = new System.Windows.Forms.Button();
            this.lbSecim = new System.Windows.Forms.Label();
            this.lbSecim_2 = new System.Windows.Forms.Label();
            this.btnSecim2 = new System.Windows.Forms.Button();
            this.cmbGunler_2 = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCikar_2 = new System.Windows.Forms.Button();
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
            this.cmbGunler.Location = new System.Drawing.Point(13, 13);
            this.cmbGunler.Name = "cmbGunler";
            this.cmbGunler.Size = new System.Drawing.Size(243, 39);
            this.cmbGunler.TabIndex = 0;
            this.cmbGunler.SelectedIndexChanged += new System.EventHandler(this.cmbGunler_SelectedIndexChanged);
            // 
            // btnSecim
            // 
            this.btnSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecim.Location = new System.Drawing.Point(280, 13);
            this.btnSecim.Name = "btnSecim";
            this.btnSecim.Size = new System.Drawing.Size(126, 39);
            this.btnSecim.TabIndex = 1;
            this.btnSecim.Text = "Seçim";
            this.btnSecim.UseVisualStyleBackColor = true;
            this.btnSecim.Click += new System.EventHandler(this.btnSecim_Click);
            // 
            // lbSecim
            // 
            this.lbSecim.AutoSize = true;
            this.lbSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSecim.Location = new System.Drawing.Point(280, 75);
            this.lbSecim.Name = "lbSecim";
            this.lbSecim.Size = new System.Drawing.Size(0, 32);
            this.lbSecim.TabIndex = 2;
            // 
            // lbSecim_2
            // 
            this.lbSecim_2.AutoSize = true;
            this.lbSecim_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSecim_2.Location = new System.Drawing.Point(280, 193);
            this.lbSecim_2.Name = "lbSecim_2";
            this.lbSecim_2.Size = new System.Drawing.Size(0, 32);
            this.lbSecim_2.TabIndex = 5;
            // 
            // btnSecim2
            // 
            this.btnSecim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecim2.Location = new System.Drawing.Point(280, 131);
            this.btnSecim2.Name = "btnSecim2";
            this.btnSecim2.Size = new System.Drawing.Size(126, 39);
            this.btnSecim2.TabIndex = 4;
            this.btnSecim2.Text = "Seçim 2";
            this.btnSecim2.UseVisualStyleBackColor = true;
            // 
            // cmbGunler_2
            // 
            this.cmbGunler_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbGunler_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGunler_2.FormattingEnabled = true;
            this.cmbGunler_2.Location = new System.Drawing.Point(13, 131);
            this.cmbGunler_2.Name = "cmbGunler_2";
            this.cmbGunler_2.Size = new System.Drawing.Size(243, 39);
            this.cmbGunler_2.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(650, 130);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 39);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkle.Location = new System.Drawing.Point(438, 131);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(206, 38);
            this.txtEkle.TabIndex = 8;
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(650, 175);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(126, 39);
            this.btnCikar.TabIndex = 9;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnCikar_2
            // 
            this.btnCikar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar_2.Location = new System.Drawing.Point(650, 220);
            this.btnCikar_2.Name = "btnCikar_2";
            this.btnCikar_2.Size = new System.Drawing.Size(126, 39);
            this.btnCikar_2.TabIndex = 10;
            this.btnCikar_2.Text = "Çıkar";
            this.btnCikar_2.UseVisualStyleBackColor = true;
            this.btnCikar_2.Click += new System.EventHandler(this.btnCikar_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikar_2);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbSecim_2);
            this.Controls.Add(this.btnSecim2);
            this.Controls.Add(this.cmbGunler_2);
            this.Controls.Add(this.lbSecim);
            this.Controls.Add(this.btnSecim);
            this.Controls.Add(this.cmbGunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGunler;
        private System.Windows.Forms.Button btnSecim;
        private System.Windows.Forms.Label lbSecim;
        private System.Windows.Forms.Label lbSecim_2;
        private System.Windows.Forms.Button btnSecim2;
        private System.Windows.Forms.ComboBox cmbGunler_2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCikar_2;
    }
}

