namespace WindowsFormsApp2
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
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnListele2 = new System.Windows.Forms.Button();
            this.btnListele3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEkran
            // 
            this.txtEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkran.Location = new System.Drawing.Point(232, 12);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(664, 417);
            this.txtEkran.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(153, 51);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele Sayı";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(12, 192);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(153, 51);
            this.btnOgrenciListele.TabIndex = 2;
            this.btnOgrenciListele.Text = "Listele Ogrenci";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnListele2
            // 
            this.btnListele2.Location = new System.Drawing.Point(12, 259);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(153, 51);
            this.btnListele2.TabIndex = 3;
            this.btnListele2.Text = "Listele Ogrenci 2";
            this.btnListele2.UseVisualStyleBackColor = true;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // btnListele3
            // 
            this.btnListele3.Location = new System.Drawing.Point(12, 85);
            this.btnListele3.Name = "btnListele3";
            this.btnListele3.Size = new System.Drawing.Size(153, 51);
            this.btnListele3.TabIndex = 4;
            this.btnListele3.Text = "Listele Sayı";
            this.btnListele3.UseVisualStyleBackColor = true;
            this.btnListele3.Click += new System.EventHandler(this.btnListele3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.btnListele3);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtEkran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnListele2;
        private System.Windows.Forms.Button btnListele3;
    }
}

