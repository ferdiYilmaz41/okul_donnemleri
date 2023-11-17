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
            this.btnYukle_1 = new System.Windows.Forms.Button();
            this.btnYukle_2 = new System.Windows.Forms.Button();
            this.btnYukle_3 = new System.Windows.Forms.Button();
            this.btnYukle_4 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcResim = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYukle_1
            // 
            this.btnYukle_1.Location = new System.Drawing.Point(17, 27);
            this.btnYukle_1.Name = "btnYukle_1";
            this.btnYukle_1.Size = new System.Drawing.Size(152, 23);
            this.btnYukle_1.TabIndex = 1;
            this.btnYukle_1.Text = "Resim AutoSize";
            this.btnYukle_1.UseVisualStyleBackColor = true;
            this.btnYukle_1.Click += new System.EventHandler(this.btnYukle_1_Click);
            // 
            // btnYukle_2
            // 
            this.btnYukle_2.Location = new System.Drawing.Point(175, 27);
            this.btnYukle_2.Name = "btnYukle_2";
            this.btnYukle_2.Size = new System.Drawing.Size(152, 23);
            this.btnYukle_2.TabIndex = 2;
            this.btnYukle_2.Text = "Resim CenterImage";
            this.btnYukle_2.UseVisualStyleBackColor = true;
            this.btnYukle_2.Click += new System.EventHandler(this.btnYukle_2_Click);
            // 
            // btnYukle_3
            // 
            this.btnYukle_3.Location = new System.Drawing.Point(333, 27);
            this.btnYukle_3.Name = "btnYukle_3";
            this.btnYukle_3.Size = new System.Drawing.Size(152, 23);
            this.btnYukle_3.TabIndex = 3;
            this.btnYukle_3.Text = "Resim Normal";
            this.btnYukle_3.UseVisualStyleBackColor = true;
            this.btnYukle_3.Click += new System.EventHandler(this.btnYukle_3_Click);
            // 
            // btnYukle_4
            // 
            this.btnYukle_4.Location = new System.Drawing.Point(491, 27);
            this.btnYukle_4.Name = "btnYukle_4";
            this.btnYukle_4.Size = new System.Drawing.Size(152, 23);
            this.btnYukle_4.TabIndex = 4;
            this.btnYukle_4.Text = "Resim StretchImage";
            this.btnYukle_4.UseVisualStyleBackColor = true;
            this.btnYukle_4.Click += new System.EventHandler(this.btnYukle_4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(649, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Resim Zoom";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.btnYukle_1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnYukle_2);
            this.panel1.Controls.Add(this.btnYukle_4);
            this.panel1.Controls.Add(this.btnYukle_3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 69);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pcResim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 381);
            this.panel2.TabIndex = 7;
            // 
            // pcResim
            // 
            this.pcResim.BackColor = System.Drawing.Color.MistyRose;
            this.pcResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcResim.Location = new System.Drawing.Point(0, 0);
            this.pcResim.Name = "pcResim";
            this.pcResim.Size = new System.Drawing.Size(915, 381);
            this.pcResim.TabIndex = 1;
            this.pcResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYukle_1;
        private System.Windows.Forms.Button btnYukle_2;
        private System.Windows.Forms.Button btnYukle_3;
        private System.Windows.Forms.Button btnYukle_4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcResim;
    }
}

