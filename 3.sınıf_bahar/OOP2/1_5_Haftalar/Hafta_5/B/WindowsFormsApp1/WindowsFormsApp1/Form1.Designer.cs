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
            this.components = new System.ComponentModel.Container();
            this.lstElemanList = new System.Windows.Forms.ListBox();
            this.btnSecimiSil = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçiliOlanlarıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajKutusuGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formRenginiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTxt = new System.Windows.Forms.MaskedTextBox();
            this.btnMaskedTb = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstElemanList
            // 
            this.lstElemanList.ContextMenuStrip = this.contextMenuStrip1;
            this.lstElemanList.FormattingEnabled = true;
            this.lstElemanList.ItemHeight = 16;
            this.lstElemanList.Location = new System.Drawing.Point(12, 12);
            this.lstElemanList.Name = "lstElemanList";
            this.lstElemanList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstElemanList.Size = new System.Drawing.Size(252, 420);
            this.lstElemanList.TabIndex = 0;
            // 
            // btnSecimiSil
            // 
            this.btnSecimiSil.Location = new System.Drawing.Point(282, 13);
            this.btnSecimiSil.Name = "btnSecimiSil";
            this.btnSecimiSil.Size = new System.Drawing.Size(132, 69);
            this.btnSecimiSil.TabIndex = 1;
            this.btnSecimiSil.Text = "Seçimi Sil";
            this.btnSecimiSil.UseVisualStyleBackColor = true;
            this.btnSecimiSil.Click += new System.EventHandler(this.btnSecimiSil_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçiliOlanlarıSilToolStripMenuItem,
            this.mesajKutusuGösterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 52);
            // 
            // seçiliOlanlarıSilToolStripMenuItem
            // 
            this.seçiliOlanlarıSilToolStripMenuItem.Name = "seçiliOlanlarıSilToolStripMenuItem";
            this.seçiliOlanlarıSilToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.seçiliOlanlarıSilToolStripMenuItem.Text = "Seçili Olanları Sil";
            this.seçiliOlanlarıSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliOlanlarıSilToolStripMenuItem_Click);
            // 
            // mesajKutusuGösterToolStripMenuItem
            // 
            this.mesajKutusuGösterToolStripMenuItem.Name = "mesajKutusuGösterToolStripMenuItem";
            this.mesajKutusuGösterToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.mesajKutusuGösterToolStripMenuItem.Text = "Mesaj Kutusu Göster";
            this.mesajKutusuGösterToolStripMenuItem.Click += new System.EventHandler(this.mesajKutusuGösterToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formRenginiDeğiştirToolStripMenuItem,
            this.formuKapatToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(223, 52);
            // 
            // formRenginiDeğiştirToolStripMenuItem
            // 
            this.formRenginiDeğiştirToolStripMenuItem.Name = "formRenginiDeğiştirToolStripMenuItem";
            this.formRenginiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.formRenginiDeğiştirToolStripMenuItem.Text = "Form Rengini Değiştir";
            this.formRenginiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.formRenginiDeğiştirToolStripMenuItem_Click);
            // 
            // formuKapatToolStripMenuItem
            // 
            this.formuKapatToolStripMenuItem.Name = "formuKapatToolStripMenuItem";
            this.formuKapatToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.formuKapatToolStripMenuItem.Text = "Formu Kapat";
            this.formuKapatToolStripMenuItem.Click += new System.EventHandler(this.formuKapatToolStripMenuItem_Click);
            // 
            // maskedTxt
            // 
            this.maskedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTxt.Location = new System.Drawing.Point(282, 105);
            this.maskedTxt.Mask = "(9999) 00 00 00 00";
            this.maskedTxt.Name = "maskedTxt";
            this.maskedTxt.Size = new System.Drawing.Size(266, 34);
            this.maskedTxt.TabIndex = 4;
            // 
            // btnMaskedTb
            // 
            this.btnMaskedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaskedTb.Location = new System.Drawing.Point(582, 93);
            this.btnMaskedTb.Name = "btnMaskedTb";
            this.btnMaskedTb.Size = new System.Drawing.Size(133, 54);
            this.btnMaskedTb.TabIndex = 5;
            this.btnMaskedTb.Text = "Oku";
            this.btnMaskedTb.UseVisualStyleBackColor = true;
            this.btnMaskedTb.Click += new System.EventHandler(this.btnMaskedTb_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.Location = new System.Drawing.Point(282, 177);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 25);
            this.lbSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btnMaskedTb);
            this.Controls.Add(this.maskedTxt);
            this.Controls.Add(this.btnSecimiSil);
            this.Controls.Add(this.lstElemanList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstElemanList;
        private System.Windows.Forms.Button btnSecimiSil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçiliOlanlarıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajKutusuGösterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem formRenginiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuKapatToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox maskedTxt;
        private System.Windows.Forms.Button btnMaskedTb;
        private System.Windows.Forms.Label lbSonuc;
    }
}

