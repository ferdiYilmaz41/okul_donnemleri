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
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.btnCokluSil = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçimleriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajKutusuÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ardalanRenginiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaske = new System.Windows.Forms.MaskedTextBox();
            this.btnCheckMask = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_liste
            // 
            this.lst_liste.ContextMenuStrip = this.contextMenuStrip1;
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.ItemHeight = 16;
            this.lst_liste.Location = new System.Drawing.Point(12, 23);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_liste.Size = new System.Drawing.Size(245, 244);
            this.lst_liste.TabIndex = 0;
            // 
            // btnCokluSil
            // 
            this.btnCokluSil.Location = new System.Drawing.Point(264, 23);
            this.btnCokluSil.Name = "btnCokluSil";
            this.btnCokluSil.Size = new System.Drawing.Size(123, 62);
            this.btnCokluSil.TabIndex = 1;
            this.btnCokluSil.Text = "Çoklu Sil";
            this.btnCokluSil.UseVisualStyleBackColor = true;
            this.btnCokluSil.Click += new System.EventHandler(this.btnCokluSil_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçimleriSilToolStripMenuItem,
            this.mesajKutusuÇıkarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 52);
            // 
            // seçimleriSilToolStripMenuItem
            // 
            this.seçimleriSilToolStripMenuItem.Name = "seçimleriSilToolStripMenuItem";
            this.seçimleriSilToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.seçimleriSilToolStripMenuItem.Text = "Seçimleri Sil";
            this.seçimleriSilToolStripMenuItem.Click += new System.EventHandler(this.seçimleriSilToolStripMenuItem_Click);
            // 
            // mesajKutusuÇıkarToolStripMenuItem
            // 
            this.mesajKutusuÇıkarToolStripMenuItem.Name = "mesajKutusuÇıkarToolStripMenuItem";
            this.mesajKutusuÇıkarToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.mesajKutusuÇıkarToolStripMenuItem.Text = "Mesaj Kutusu Çıkar";
            this.mesajKutusuÇıkarToolStripMenuItem.Click += new System.EventHandler(this.mesajKutusuÇıkarToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuKapatToolStripMenuItem,
            this.ardalanRenginiDeğiştirToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(241, 106);
            // 
            // formuKapatToolStripMenuItem
            // 
            this.formuKapatToolStripMenuItem.Name = "formuKapatToolStripMenuItem";
            this.formuKapatToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.formuKapatToolStripMenuItem.Text = "Formu Kapat";
            this.formuKapatToolStripMenuItem.Click += new System.EventHandler(this.formuKapatToolStripMenuItem_Click);
            // 
            // ardalanRenginiDeğiştirToolStripMenuItem
            // 
            this.ardalanRenginiDeğiştirToolStripMenuItem.Name = "ardalanRenginiDeğiştirToolStripMenuItem";
            this.ardalanRenginiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.ardalanRenginiDeğiştirToolStripMenuItem.Text = "Ardalan Rengini Değiştir";
            this.ardalanRenginiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.ardalanRenginiDeğiştirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(240, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // txtMaske
            // 
            this.txtMaske.Location = new System.Drawing.Point(12, 300);
            this.txtMaske.Mask = "(999) 00-00-0-00";
            this.txtMaske.Name = "txtMaske";
            this.txtMaske.Size = new System.Drawing.Size(192, 22);
            this.txtMaske.TabIndex = 4;
            // 
            // btnCheckMask
            // 
            this.btnCheckMask.Location = new System.Drawing.Point(290, 300);
            this.btnCheckMask.Name = "btnCheckMask";
            this.btnCheckMask.Size = new System.Drawing.Size(123, 62);
            this.btnCheckMask.TabIndex = 5;
            this.btnCheckMask.Text = "Maske Kontrol";
            this.btnCheckMask.UseVisualStyleBackColor = true;
            this.btnCheckMask.Click += new System.EventHandler(this.btnCheckMask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.btnCheckMask);
            this.Controls.Add(this.txtMaske);
            this.Controls.Add(this.btnCokluSil);
            this.Controls.Add(this.lst_liste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.Button btnCokluSil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçimleriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajKutusuÇıkarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem formuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ardalanRenginiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MaskedTextBox txtMaske;
        private System.Windows.Forms.Button btnCheckMask;
    }
}

