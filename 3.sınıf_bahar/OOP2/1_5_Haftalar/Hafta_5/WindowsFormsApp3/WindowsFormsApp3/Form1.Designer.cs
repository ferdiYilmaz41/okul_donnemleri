namespace WindowsFormsApp3
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
            this.pcResim = new System.Windows.Forms.PictureBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnYukle2 = new System.Windows.Forms.Button();
            this.btnYukle3 = new System.Windows.Forms.Button();
            this.btnYukle4 = new System.Windows.Forms.Button();
            this.btnYukle5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Yukle_5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcResim)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcResim
            // 
            this.pcResim.BackColor = System.Drawing.Color.LightSalmon;
            this.pcResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcResim.Location = new System.Drawing.Point(0, 0);
            this.pcResim.Name = "pcResim";
            this.pcResim.Size = new System.Drawing.Size(1040, 484);
            this.pcResim.TabIndex = 0;
            this.pcResim.TabStop = false;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(3, 28);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(149, 37);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Yükle (AutoSize)";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnYukle2
            // 
            this.btnYukle2.Location = new System.Drawing.Point(158, 28);
            this.btnYukle2.Name = "btnYukle2";
            this.btnYukle2.Size = new System.Drawing.Size(149, 37);
            this.btnYukle2.TabIndex = 2;
            this.btnYukle2.Text = "Yükle (CenterImage)";
            this.btnYukle2.UseVisualStyleBackColor = true;
            this.btnYukle2.Click += new System.EventHandler(this.btnYukle2_Click);
            // 
            // btnYukle3
            // 
            this.btnYukle3.Location = new System.Drawing.Point(313, 28);
            this.btnYukle3.Name = "btnYukle3";
            this.btnYukle3.Size = new System.Drawing.Size(149, 37);
            this.btnYukle3.TabIndex = 3;
            this.btnYukle3.Text = "Yükle (Normal)";
            this.btnYukle3.UseVisualStyleBackColor = true;
            this.btnYukle3.Click += new System.EventHandler(this.btnYukle3_Click);
            // 
            // btnYukle4
            // 
            this.btnYukle4.Location = new System.Drawing.Point(468, 28);
            this.btnYukle4.Name = "btnYukle4";
            this.btnYukle4.Size = new System.Drawing.Size(149, 37);
            this.btnYukle4.TabIndex = 4;
            this.btnYukle4.Text = "Yükle (AutoSize)";
            this.btnYukle4.UseVisualStyleBackColor = true;
            this.btnYukle4.Click += new System.EventHandler(this.btnYukle4_Click);
            // 
            // btnYukle5
            // 
            this.btnYukle5.Location = new System.Drawing.Point(623, 28);
            this.btnYukle5.Name = "btnYukle5";
            this.btnYukle5.Size = new System.Drawing.Size(149, 37);
            this.btnYukle5.TabIndex = 5;
            this.btnYukle5.Text = "Yükle (Zoom)";
            this.btnYukle5.UseVisualStyleBackColor = true;
            this.btnYukle5.Click += new System.EventHandler(this.btnYukle5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcResim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 484);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.Yukle_5);
            this.panel2.Controls.Add(this.btnYukle);
            this.panel2.Controls.Add(this.btnYukle2);
            this.panel2.Controls.Add(this.btnYukle5);
            this.panel2.Controls.Add(this.btnYukle3);
            this.panel2.Controls.Add(this.btnYukle4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 119);
            this.panel2.TabIndex = 7;
            // 
            // Yukle_5
            // 
            this.Yukle_5.Location = new System.Drawing.Point(3, 79);
            this.Yukle_5.Name = "Yukle_5";
            this.Yukle_5.Size = new System.Drawing.Size(149, 37);
            this.Yukle_5.TabIndex = 6;
            this.Yukle_5.Text = "Yükle (AutoSize)";
            this.Yukle_5.UseVisualStyleBackColor = true;
            this.Yukle_5.Click += new System.EventHandler(this.Yukle_5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcResim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcResim;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnYukle2;
        private System.Windows.Forms.Button btnYukle3;
        private System.Windows.Forms.Button btnYukle4;
        private System.Windows.Forms.Button btnYukle5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Yukle_5;
    }
}

