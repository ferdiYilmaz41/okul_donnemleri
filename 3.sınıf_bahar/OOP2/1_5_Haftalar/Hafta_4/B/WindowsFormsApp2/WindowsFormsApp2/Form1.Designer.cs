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
            this.btnListele = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnOgre_ArrayListe = new System.Windows.Forms.Button();
            this.ogrArrayDegistir = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(12, 23);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(149, 40);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkran.Location = new System.Drawing.Point(182, 25);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(493, 415);
            this.txtEkran.TabIndex = 1;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(12, 81);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(149, 40);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnOgre_ArrayListe
            // 
            this.btnOgre_ArrayListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgre_ArrayListe.Location = new System.Drawing.Point(681, 25);
            this.btnOgre_ArrayListe.Name = "btnOgre_ArrayListe";
            this.btnOgre_ArrayListe.Size = new System.Drawing.Size(394, 40);
            this.btnOgre_ArrayListe.TabIndex = 3;
            this.btnOgre_ArrayListe.Text = "Listele Sınıf Dizisi";
            this.btnOgre_ArrayListe.UseVisualStyleBackColor = true;
            this.btnOgre_ArrayListe.Click += new System.EventHandler(this.btnOgre_ArrayListe_Click);
            // 
            // ogrArrayDegistir
            // 
            this.ogrArrayDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrArrayDegistir.Location = new System.Drawing.Point(681, 81);
            this.ogrArrayDegistir.Name = "ogrArrayDegistir";
            this.ogrArrayDegistir.Size = new System.Drawing.Size(394, 40);
            this.ogrArrayDegistir.TabIndex = 4;
            this.ogrArrayDegistir.Text = "Listele Sınıf Dizisi Değiştir";
            this.ogrArrayDegistir.UseVisualStyleBackColor = true;
            this.ogrArrayDegistir.Click += new System.EventHandler(this.ogrArrayDegistir_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForeach.Location = new System.Drawing.Point(681, 175);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(394, 40);
            this.btnForeach.TabIndex = 5;
            this.btnForeach.Text = "foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.ogrArrayDegistir);
            this.Controls.Add(this.btnOgre_ArrayListe);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnOgre_ArrayListe;
        private System.Windows.Forms.Button ogrArrayDegistir;
        private System.Windows.Forms.Button btnForeach;
    }
}

