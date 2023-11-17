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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.BtnOku = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.lbEkran = new System.Windows.Forms.Label();
            this.btnYaz_ML = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lbSifre = new System.Windows.Forms.Label();
            this.btnSifre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.lbEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEkran
            // 
            this.txtEkran.BackColor = System.Drawing.SystemColors.Window;
            this.txtEkran.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEkran.Location = new System.Drawing.Point(22, 25);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(251, 108);
            this.txtEkran.TabIndex = 0;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(22, 166);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(75, 23);
            this.btnYaz.TabIndex = 4;
            this.btnYaz.Text = "Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // BtnOku
            // 
            this.BtnOku.Location = new System.Drawing.Point(198, 166);
            this.BtnOku.Name = "BtnOku";
            this.BtnOku.Size = new System.Drawing.Size(75, 23);
            this.BtnOku.TabIndex = 6;
            this.BtnOku.Text = "Oku";
            this.BtnOku.UseVisualStyleBackColor = true;
            this.BtnOku.Click += new System.EventHandler(this.BtnOku_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(110, 166);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(75, 23);
            this.btnRenk.TabIndex = 5;
            this.btnRenk.Text = "Renk";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // lbEkran
            // 
            this.lbEkran.AutoSize = true;
            this.lbEkran.Location = new System.Drawing.Point(337, 28);
            this.lbEkran.Name = "lbEkran";
            this.lbEkran.Size = new System.Drawing.Size(0, 13);
            this.lbEkran.TabIndex = 4;
            // 
            // btnYaz_ML
            // 
            this.btnYaz_ML.Location = new System.Drawing.Point(22, 212);
            this.btnYaz_ML.Name = "btnYaz_ML";
            this.btnYaz_ML.Size = new System.Drawing.Size(75, 23);
            this.btnYaz_ML.TabIndex = 7;
            this.btnYaz_ML.Text = "Ml. Yaz";
            this.btnYaz_ML.UseVisualStyleBackColor = true;
            this.btnYaz_ML.Click += new System.EventHandler(this.btnYaz_ML_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(22, 255);
            this.txtSifre.MaxLength = 4;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(251, 29);
            this.txtSifre.TabIndex = 8;
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Location = new System.Drawing.Point(150, 258);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(0, 13);
            this.lbSifre.TabIndex = 9;
            // 
            // btnSifre
            // 
            this.btnSifre.Location = new System.Drawing.Point(22, 292);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(75, 23);
            this.btnSifre.TabIndex = 10;
            this.btnSifre.Text = "Şifre Oku";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Şifre Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEvent
            // 
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEvent.Location = new System.Drawing.Point(380, 28);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(279, 29);
            this.txtEvent.TabIndex = 12;
            this.txtEvent.TextChanged += new System.EventHandler(this.txtEvent_TextChanged);
            this.txtEvent.Enter += new System.EventHandler(this.txtEvent_Enter);
            this.txtEvent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEvent_KeyDown);
            this.txtEvent.Leave += new System.EventHandler(this.txtEvent_Leave);
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbEvent.Location = new System.Drawing.Point(380, 69);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(0, 24);
            this.lbEvent.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSifre);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnYaz_ML);
            this.Controls.Add(this.lbEkran);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.BtnOku);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtEkran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FORMUN BAŞLIĞI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button BtnOku;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Label lbEkran;
        private System.Windows.Forms.Button btnYaz_ML;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label lbEvent;
    }
}

