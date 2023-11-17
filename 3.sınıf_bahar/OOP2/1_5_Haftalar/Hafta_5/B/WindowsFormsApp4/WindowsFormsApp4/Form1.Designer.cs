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
            this.lstKediListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTekSatir = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtCinsi = new System.Windows.Forms.TextBox();
            this.txtYasi = new System.Windows.Forms.TextBox();
            this.btnEkleParametre = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcKedi = new System.Windows.Forms.PictureBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcKedi)).BeginInit();
            this.SuspendLayout();
            // 
            // lstKediListesi
            // 
            this.lstKediListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstKediListesi.FullRowSelect = true;
            this.lstKediListesi.GridLines = true;
            this.lstKediListesi.HideSelection = false;
            this.lstKediListesi.Location = new System.Drawing.Point(12, 12);
            this.lstKediListesi.Name = "lstKediListesi";
            this.lstKediListesi.Size = new System.Drawing.Size(338, 426);
            this.lstKediListesi.TabIndex = 0;
            this.lstKediListesi.UseCompatibleStateImageBehavior = false;
            this.lstKediListesi.View = System.Windows.Forms.View.Details;
            this.lstKediListesi.SelectedIndexChanged += new System.EventHandler(this.lstKediListesi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cinsi";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yaşı";
            this.columnHeader3.Width = 110;
            // 
            // btnTekSatir
            // 
            this.btnTekSatir.Location = new System.Drawing.Point(384, 12);
            this.btnTekSatir.Name = "btnTekSatir";
            this.btnTekSatir.Size = new System.Drawing.Size(100, 23);
            this.btnTekSatir.TabIndex = 1;
            this.btnTekSatir.Text = "Ekle 1";
            this.btnTekSatir.UseVisualStyleBackColor = true;
            this.btnTekSatir.Click += new System.EventHandler(this.btnTekSatir_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(490, 41);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 22);
            this.txtAdi.TabIndex = 2;
            // 
            // txtCinsi
            // 
            this.txtCinsi.Location = new System.Drawing.Point(490, 69);
            this.txtCinsi.Name = "txtCinsi";
            this.txtCinsi.Size = new System.Drawing.Size(100, 22);
            this.txtCinsi.TabIndex = 3;
            // 
            // txtYasi
            // 
            this.txtYasi.Location = new System.Drawing.Point(490, 97);
            this.txtYasi.Name = "txtYasi";
            this.txtYasi.Size = new System.Drawing.Size(100, 22);
            this.txtYasi.TabIndex = 4;
            // 
            // btnEkleParametre
            // 
            this.btnEkleParametre.Location = new System.Drawing.Point(490, 12);
            this.btnEkleParametre.Name = "btnEkleParametre";
            this.btnEkleParametre.Size = new System.Drawing.Size(100, 23);
            this.btnEkleParametre.TabIndex = 5;
            this.btnEkleParametre.Text = "Ekle 2";
            this.btnEkleParametre.UseVisualStyleBackColor = true;
            this.btnEkleParametre.Click += new System.EventHandler(this.btnEkleParametre_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Resim";
            // 
            // pcKedi
            // 
            this.pcKedi.Location = new System.Drawing.Point(490, 144);
            this.pcKedi.Name = "pcKedi";
            this.pcKedi.Size = new System.Drawing.Size(280, 294);
            this.pcKedi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcKedi.TabIndex = 6;
            this.pcKedi.TabStop = false;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(622, 12);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(100, 23);
            this.btnDegistir.TabIndex = 7;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.pcKedi);
            this.Controls.Add(this.btnEkleParametre);
            this.Controls.Add(this.txtYasi);
            this.Controls.Add(this.txtCinsi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnTekSatir);
            this.Controls.Add(this.lstKediListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcKedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstKediListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnTekSatir;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtCinsi;
        private System.Windows.Forms.TextBox txtYasi;
        private System.Windows.Forms.Button btnEkleParametre;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pcKedi;
        private System.Windows.Forms.Button btnDegistir;
    }
}

