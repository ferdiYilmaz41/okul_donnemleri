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
            this.btnYaz = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnRenk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorder = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnPassRead = new System.Windows.Forms.Button();
            this.lbSifre = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.Image = global::WindowsFormsApp1.Properties.Resources.device;
            this.btnYaz.Location = new System.Drawing.Point(12, 29);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(159, 76);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "Yaz";
            this.btnYaz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.BackColor = System.Drawing.Color.Red;
            this.txtEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkran.ForeColor = System.Drawing.Color.White;
            this.txtEkran.Location = new System.Drawing.Point(193, 29);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(272, 76);
            this.txtEkran.TabIndex = 4;
            // 
            // btnRenk
            // 
            this.btnRenk.Image = global::WindowsFormsApp1.Properties.Resources.device;
            this.btnRenk.Location = new System.Drawing.Point(12, 106);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(159, 76);
            this.btnRenk.TabIndex = 1;
            this.btnRenk.Text = "Renk";
            this.btnRenk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.device;
            this.button1.Location = new System.Drawing.Point(12, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "M.L Write";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorder
            // 
            this.btnBorder.Image = global::WindowsFormsApp1.Properties.Resources.device;
            this.btnBorder.Location = new System.Drawing.Point(12, 270);
            this.btnBorder.Name = "btnBorder";
            this.btnBorder.Size = new System.Drawing.Size(159, 76);
            this.btnBorder.TabIndex = 3;
            this.btnBorder.Text = "Border";
            this.btnBorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorder.UseVisualStyleBackColor = true;
            this.btnBorder.Click += new System.EventHandler(this.btnBorder_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(193, 160);
            this.txtSifre.MaxLength = 50;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(272, 45);
            this.txtSifre.TabIndex = 7;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // btnPassRead
            // 
            this.btnPassRead.Location = new System.Drawing.Point(486, 160);
            this.btnPassRead.Name = "btnPassRead";
            this.btnPassRead.Size = new System.Drawing.Size(128, 36);
            this.btnPassRead.TabIndex = 8;
            this.btnPassRead.Text = "Read Password";
            this.btnPassRead.UseVisualStyleBackColor = true;
            this.btnPassRead.Click += new System.EventHandler(this.btnPassRead_Click);
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Location = new System.Drawing.Point(193, 218);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(0, 17);
            this.lbSifre.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(637, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.btnPassRead);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnBorder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnYaz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form Başlığı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBorder;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnPassRead;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.Button btnClear;
    }
}

