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
            this.chkCorap = new System.Windows.Forms.CheckBox();
            this.chkKazak = new System.Windows.Forms.CheckBox();
            this.chkAtki = new System.Windows.Forms.CheckBox();
            this.lbToplamTutar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIndirim = new System.Windows.Forms.Label();
            this.lbOdenecek = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbIndirimYap10 = new System.Windows.Forms.RadioButton();
            this.rbIndirimYapma = new System.Windows.Forms.RadioButton();
            this.rbIndirimYap20 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCorap
            // 
            this.chkCorap.AutoSize = true;
            this.chkCorap.Location = new System.Drawing.Point(12, 22);
            this.chkCorap.Name = "chkCorap";
            this.chkCorap.Size = new System.Drawing.Size(101, 21);
            this.chkCorap.TabIndex = 0;
            this.chkCorap.Text = "Çorap 1 TL";
            this.chkCorap.UseVisualStyleBackColor = true;
            this.chkCorap.CheckedChanged += new System.EventHandler(this.chkCorap_CheckedChanged);
            // 
            // chkKazak
            // 
            this.chkKazak.AutoSize = true;
            this.chkKazak.Location = new System.Drawing.Point(12, 49);
            this.chkKazak.Name = "chkKazak";
            this.chkKazak.Size = new System.Drawing.Size(102, 21);
            this.chkKazak.TabIndex = 1;
            this.chkKazak.Text = "Kazak 2 TL";
            this.chkKazak.UseVisualStyleBackColor = true;
            this.chkKazak.CheckedChanged += new System.EventHandler(this.chkKazak_CheckedChanged);
            // 
            // chkAtki
            // 
            this.chkAtki.AutoSize = true;
            this.chkAtki.Location = new System.Drawing.Point(12, 76);
            this.chkAtki.Name = "chkAtki";
            this.chkAtki.Size = new System.Drawing.Size(86, 21);
            this.chkAtki.TabIndex = 2;
            this.chkAtki.Text = "Atkı 3 TL";
            this.chkAtki.UseVisualStyleBackColor = true;
            this.chkAtki.CheckedChanged += new System.EventHandler(this.chkAtki_CheckedChanged);
            // 
            // lbToplamTutar
            // 
            this.lbToplamTutar.AutoSize = true;
            this.lbToplamTutar.Location = new System.Drawing.Point(12, 202);
            this.lbToplamTutar.Name = "lbToplamTutar";
            this.lbToplamTutar.Size = new System.Drawing.Size(0, 17);
            this.lbToplamTutar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "__________________________";
            // 
            // lbIndirim
            // 
            this.lbIndirim.AutoSize = true;
            this.lbIndirim.Location = new System.Drawing.Point(12, 228);
            this.lbIndirim.Name = "lbIndirim";
            this.lbIndirim.Size = new System.Drawing.Size(0, 17);
            this.lbIndirim.TabIndex = 7;
            // 
            // lbOdenecek
            // 
            this.lbOdenecek.AutoSize = true;
            this.lbOdenecek.Location = new System.Drawing.Point(12, 262);
            this.lbOdenecek.Name = "lbOdenecek";
            this.lbOdenecek.Size = new System.Drawing.Size(0, 17);
            this.lbOdenecek.TabIndex = 8;
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(12, 113);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(75, 23);
            this.btnOdeme.TabIndex = 10;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(6, 21);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(65, 21);
            this.rbKadin.TabIndex = 11;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(6, 47);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 21);
            this.rbErkek.TabIndex = 12;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Location = new System.Drawing.Point(516, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 89);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbIndirimYap10);
            this.groupBox2.Controls.Add(this.rbIndirimYapma);
            this.groupBox2.Controls.Add(this.rbIndirimYap20);
            this.groupBox2.Location = new System.Drawing.Point(301, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 121);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İndirim Oranı";
            // 
            // rbIndirimYap10
            // 
            this.rbIndirimYap10.AutoSize = true;
            this.rbIndirimYap10.Location = new System.Drawing.Point(6, 47);
            this.rbIndirimYap10.Name = "rbIndirimYap10";
            this.rbIndirimYap10.Size = new System.Drawing.Size(155, 21);
            this.rbIndirimYap10.TabIndex = 12;
            this.rbIndirimYap10.Text = "İndirim Yapılsın %10";
            this.rbIndirimYap10.UseVisualStyleBackColor = true;
            // 
            // rbIndirimYapma
            // 
            this.rbIndirimYapma.AutoSize = true;
            this.rbIndirimYapma.Checked = true;
            this.rbIndirimYapma.Location = new System.Drawing.Point(6, 74);
            this.rbIndirimYapma.Name = "rbIndirimYapma";
            this.rbIndirimYapma.Size = new System.Drawing.Size(142, 21);
            this.rbIndirimYapma.TabIndex = 11;
            this.rbIndirimYapma.TabStop = true;
            this.rbIndirimYapma.Text = "İndirim Yapılmasın";
            this.rbIndirimYapma.UseVisualStyleBackColor = true;
            // 
            // rbIndirimYap20
            // 
            this.rbIndirimYap20.AutoSize = true;
            this.rbIndirimYap20.Location = new System.Drawing.Point(6, 21);
            this.rbIndirimYap20.Name = "rbIndirimYap20";
            this.rbIndirimYap20.Size = new System.Drawing.Size(155, 21);
            this.rbIndirimYap20.TabIndex = 10;
            this.rbIndirimYap20.Text = "İndirim Yapılsın %20";
            this.rbIndirimYap20.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(148, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 15;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(148, 50);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 16;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(148, 78);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.lbOdenecek);
            this.Controls.Add(this.lbIndirim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbToplamTutar);
            this.Controls.Add(this.chkAtki);
            this.Controls.Add(this.chkKazak);
            this.Controls.Add(this.chkCorap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCorap;
        private System.Windows.Forms.CheckBox chkKazak;
        private System.Windows.Forms.CheckBox chkAtki;
        private System.Windows.Forms.Label lbToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIndirim;
        private System.Windows.Forms.Label lbOdenecek;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbIndirimYap10;
        private System.Windows.Forms.RadioButton rbIndirimYapma;
        private System.Windows.Forms.RadioButton rbIndirimYap20;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

