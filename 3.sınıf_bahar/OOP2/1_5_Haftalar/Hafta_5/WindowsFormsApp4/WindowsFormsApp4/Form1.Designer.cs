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
            this.lstOgrListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSeciliIndex = new System.Windows.Forms.Label();
            this.pcResim = new System.Windows.Forms.PictureBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pcResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOgrListe
            // 
            this.lstOgrListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstOgrListe.FullRowSelect = true;
            this.lstOgrListe.GridLines = true;
            this.lstOgrListe.HideSelection = false;
            this.lstOgrListe.Location = new System.Drawing.Point(12, 12);
            this.lstOgrListe.MultiSelect = false;
            this.lstOgrListe.Name = "lstOgrListe";
            this.lstOgrListe.Size = new System.Drawing.Size(519, 426);
            this.lstOgrListe.TabIndex = 0;
            this.lstOgrListe.UseCompatibleStateImageBehavior = false;
            this.lstOgrListe.View = System.Windows.Forms.View.Details;
            this.lstOgrListe.SelectedIndexChanged += new System.EventHandler(this.lstOgrListe_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numara";
            this.columnHeader4.Width = 150;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(759, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 51);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(584, 13);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(146, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(584, 41);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(146, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(583, 69);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(146, 22);
            this.txtNo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSeciliIndex
            // 
            this.lbSeciliIndex.AutoSize = true;
            this.lbSeciliIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSeciliIndex.Location = new System.Drawing.Point(578, 106);
            this.lbSeciliIndex.Name = "lbSeciliIndex";
            this.lbSeciliIndex.Size = new System.Drawing.Size(93, 32);
            this.lbSeciliIndex.TabIndex = 6;
            this.lbSeciliIndex.Text = "label1";
            // 
            // pcResim
            // 
            this.pcResim.Location = new System.Drawing.Point(584, 187);
            this.pcResim.Name = "pcResim";
            this.pcResim.Size = new System.Drawing.Size(254, 227);
            this.pcResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcResim.TabIndex = 7;
            this.pcResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.pcResim);
            this.Controls.Add(this.lbSeciliIndex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstOgrListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstOgrListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSeciliIndex;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pcResim;
    }
}

