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
            this.btnOku = new System.Windows.Forms.Button();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtArabaMarka = new System.Windows.Forms.TextBox();
            this.txtArabaModel = new System.Windows.Forms.TextBox();
            this.txtKmMenzil = new System.Windows.Forms.TextBox();
            this.btnOkuAraba = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(222, 24);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(102, 46);
            this.btnOku.TabIndex = 0;
            this.btnOku.Text = "Oku Öğrenci";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(12, 24);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(176, 41);
            this.txtOgrAd.TabIndex = 1;
            // 
            // txtArabaMarka
            // 
            this.txtArabaMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtArabaMarka.Location = new System.Drawing.Point(357, 24);
            this.txtArabaMarka.Name = "txtArabaMarka";
            this.txtArabaMarka.Size = new System.Drawing.Size(176, 41);
            this.txtArabaMarka.TabIndex = 2;
            // 
            // txtArabaModel
            // 
            this.txtArabaModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtArabaModel.Location = new System.Drawing.Point(357, 82);
            this.txtArabaModel.Name = "txtArabaModel";
            this.txtArabaModel.Size = new System.Drawing.Size(176, 41);
            this.txtArabaModel.TabIndex = 3;
            // 
            // txtKmMenzil
            // 
            this.txtKmMenzil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtKmMenzil.Location = new System.Drawing.Point(357, 140);
            this.txtKmMenzil.Name = "txtKmMenzil";
            this.txtKmMenzil.Size = new System.Drawing.Size(176, 41);
            this.txtKmMenzil.TabIndex = 4;
            // 
            // btnOkuAraba
            // 
            this.btnOkuAraba.Location = new System.Drawing.Point(583, 24);
            this.btnOkuAraba.Name = "btnOkuAraba";
            this.btnOkuAraba.Size = new System.Drawing.Size(102, 46);
            this.btnOkuAraba.TabIndex = 5;
            this.btnOkuAraba.Text = "Oku Araba";
            this.btnOkuAraba.UseVisualStyleBackColor = true;
            this.btnOkuAraba.Click += new System.EventHandler(this.btnOkuAraba_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.Location = new System.Drawing.Point(184, 335);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 39);
            this.lbSonuc.TabIndex = 6;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSayi2.Location = new System.Drawing.Point(96, 284);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(66, 41);
            this.txtSayi2.TabIndex = 8;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSayi1.Location = new System.Drawing.Point(12, 284);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(66, 41);
            this.txtSayi1.TabIndex = 7;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(184, 284);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 39);
            this.btnTopla.TabIndex = 9;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btnOkuAraba);
            this.Controls.Add(this.txtKmMenzil);
            this.Controls.Add(this.txtArabaModel);
            this.Controls.Add(this.txtArabaMarka);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.btnOku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtArabaMarka;
        private System.Windows.Forms.TextBox txtArabaModel;
        private System.Windows.Forms.TextBox txtKmMenzil;
        private System.Windows.Forms.Button btnOkuAraba;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button btnTopla;
    }
}

