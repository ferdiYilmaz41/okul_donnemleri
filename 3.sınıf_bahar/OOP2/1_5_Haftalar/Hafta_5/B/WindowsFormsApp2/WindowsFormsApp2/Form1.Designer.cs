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
            this.rbIndirim0 = new System.Windows.Forms.RadioButton();
            this.rbIndirim10 = new System.Windows.Forms.RadioButton();
            this.cbCorap = new System.Windows.Forms.CheckBox();
            this.cbPantolon = new System.Windows.Forms.CheckBox();
            this.cbAyakkabi = new System.Windows.Forms.CheckBox();
            this.rbIndirim20 = new System.Windows.Forms.RadioButton();
            this.lbAraToplam = new System.Windows.Forms.Label();
            this.lbIndirimTutari = new System.Windows.Forms.Label();
            this.lbOdenecek = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // rbIndirim0
            // 
            this.rbIndirim0.AutoSize = true;
            this.rbIndirim0.Checked = true;
            this.rbIndirim0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbIndirim0.Location = new System.Drawing.Point(6, 21);
            this.rbIndirim0.Name = "rbIndirim0";
            this.rbIndirim0.Size = new System.Drawing.Size(129, 29);
            this.rbIndirim0.TabIndex = 0;
            this.rbIndirim0.TabStop = true;
            this.rbIndirim0.Text = "İndirim Yok";
            this.rbIndirim0.UseVisualStyleBackColor = true;
            this.rbIndirim0.CheckedChanged += new System.EventHandler(this.rbSecim1_CheckedChanged);
            // 
            // rbIndirim10
            // 
            this.rbIndirim10.AutoSize = true;
            this.rbIndirim10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbIndirim10.Location = new System.Drawing.Point(6, 48);
            this.rbIndirim10.Name = "rbIndirim10";
            this.rbIndirim10.Size = new System.Drawing.Size(135, 29);
            this.rbIndirim10.TabIndex = 1;
            this.rbIndirim10.Text = "İndirim %10";
            this.rbIndirim10.UseVisualStyleBackColor = true;
            this.rbIndirim10.CheckedChanged += new System.EventHandler(this.rbSecim2_CheckedChanged);
            // 
            // cbCorap
            // 
            this.cbCorap.AutoSize = true;
            this.cbCorap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCorap.Location = new System.Drawing.Point(6, 21);
            this.cbCorap.Name = "cbCorap";
            this.cbCorap.Size = new System.Drawing.Size(149, 29);
            this.cbCorap.TabIndex = 2;
            this.cbCorap.Text = "Çorap  10 TL";
            this.cbCorap.UseVisualStyleBackColor = true;
            this.cbCorap.CheckedChanged += new System.EventHandler(this.cbCorap_CheckedChanged);
            // 
            // cbPantolon
            // 
            this.cbPantolon.AutoSize = true;
            this.cbPantolon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPantolon.Location = new System.Drawing.Point(6, 48);
            this.cbPantolon.Name = "cbPantolon";
            this.cbPantolon.Size = new System.Drawing.Size(167, 29);
            this.cbPantolon.TabIndex = 3;
            this.cbPantolon.Text = "Pantolon 20 TL";
            this.cbPantolon.UseVisualStyleBackColor = true;
            this.cbPantolon.CheckedChanged += new System.EventHandler(this.cbPantolon_CheckedChanged);
            // 
            // cbAyakkabi
            // 
            this.cbAyakkabi.AutoSize = true;
            this.cbAyakkabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAyakkabi.Location = new System.Drawing.Point(6, 76);
            this.cbAyakkabi.Name = "cbAyakkabi";
            this.cbAyakkabi.Size = new System.Drawing.Size(171, 29);
            this.cbAyakkabi.TabIndex = 4;
            this.cbAyakkabi.Text = "Ayakkabı 30 TL";
            this.cbAyakkabi.UseVisualStyleBackColor = true;
            this.cbAyakkabi.CheckedChanged += new System.EventHandler(this.cbAyakkabi_CheckedChanged);
            // 
            // rbIndirim20
            // 
            this.rbIndirim20.AutoSize = true;
            this.rbIndirim20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbIndirim20.Location = new System.Drawing.Point(6, 75);
            this.rbIndirim20.Name = "rbIndirim20";
            this.rbIndirim20.Size = new System.Drawing.Size(135, 29);
            this.rbIndirim20.TabIndex = 5;
            this.rbIndirim20.Text = "İndirim %20";
            this.rbIndirim20.UseVisualStyleBackColor = true;
            // 
            // lbAraToplam
            // 
            this.lbAraToplam.AutoSize = true;
            this.lbAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAraToplam.Location = new System.Drawing.Point(30, 180);
            this.lbAraToplam.Name = "lbAraToplam";
            this.lbAraToplam.Size = new System.Drawing.Size(0, 25);
            this.lbAraToplam.TabIndex = 6;
            this.lbAraToplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIndirimTutari
            // 
            this.lbIndirimTutari.AutoSize = true;
            this.lbIndirimTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbIndirimTutari.Location = new System.Drawing.Point(30, 214);
            this.lbIndirimTutari.Name = "lbIndirimTutari";
            this.lbIndirimTutari.Size = new System.Drawing.Size(0, 25);
            this.lbIndirimTutari.TabIndex = 7;
            // 
            // lbOdenecek
            // 
            this.lbOdenecek.AutoSize = true;
            this.lbOdenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbOdenecek.Location = new System.Drawing.Point(30, 244);
            this.lbOdenecek.Name = "lbOdenecek";
            this.lbOdenecek.Size = new System.Drawing.Size(0, 25);
            this.lbOdenecek.TabIndex = 8;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadin.Location = new System.Drawing.Point(6, 21);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(84, 29);
            this.rbKadin.TabIndex = 9;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.Location = new System.Drawing.Point(6, 49);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(83, 29);
            this.rbErkek.TabIndex = 10;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIndirim0);
            this.groupBox1.Controls.Add(this.rbIndirim10);
            this.groupBox1.Controls.Add(this.rbIndirim20);
            this.groupBox1.Location = new System.Drawing.Point(245, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 120);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İndirim Oranı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKadin);
            this.groupBox2.Controls.Add(this.rbErkek);
            this.groupBox2.Location = new System.Drawing.Point(457, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 120);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.cbCorap);
            this.groupBox3.Controls.Add(this.cbPantolon);
            this.groupBox3.Controls.Add(this.cbAyakkabi);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 120);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mallar";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(173, 21);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(173, 49);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(173, 75);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOdenecek);
            this.Controls.Add(this.lbIndirimTutari);
            this.Controls.Add(this.lbAraToplam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbIndirim0;
        private System.Windows.Forms.RadioButton rbIndirim10;
        private System.Windows.Forms.CheckBox cbCorap;
        private System.Windows.Forms.CheckBox cbPantolon;
        private System.Windows.Forms.CheckBox cbAyakkabi;
        private System.Windows.Forms.RadioButton rbIndirim20;
        private System.Windows.Forms.Label lbAraToplam;
        private System.Windows.Forms.Label lbIndirimTutari;
        private System.Windows.Forms.Label lbOdenecek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

