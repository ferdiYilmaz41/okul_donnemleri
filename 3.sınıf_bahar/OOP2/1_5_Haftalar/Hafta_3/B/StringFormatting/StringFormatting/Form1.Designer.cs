namespace StringFormatting
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.dpZaman = new System.Windows.Forms.DateTimePicker();
            this.btnAddDay = new System.Windows.Forms.Button();
            this.btnSubDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi.Location = new System.Drawing.Point(28, 13);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(298, 30);
            this.txtSayi.TabIndex = 0;
            // 
            // btnFormat
            // 
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormat.Location = new System.Drawing.Point(358, 11);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(149, 32);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "Formatlama";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkran.Location = new System.Drawing.Point(246, 99);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(713, 492);
            this.txtEkran.TabIndex = 2;
            // 
            // dpZaman
            // 
            this.dpZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dpZaman.Location = new System.Drawing.Point(28, 49);
            this.dpZaman.Name = "dpZaman";
            this.dpZaman.Size = new System.Drawing.Size(298, 30);
            this.dpZaman.TabIndex = 3;
            this.dpZaman.ValueChanged += new System.EventHandler(this.dpZaman_ValueChanged);
            // 
            // btnAddDay
            // 
            this.btnAddDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDay.Location = new System.Drawing.Point(358, 50);
            this.btnAddDay.Name = "btnAddDay";
            this.btnAddDay.Size = new System.Drawing.Size(149, 32);
            this.btnAddDay.TabIndex = 4;
            this.btnAddDay.Text = "Add Day";
            this.btnAddDay.UseVisualStyleBackColor = true;
            this.btnAddDay.Click += new System.EventHandler(this.btnAddDay_Click);
            // 
            // btnSubDay
            // 
            this.btnSubDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubDay.Location = new System.Drawing.Point(513, 50);
            this.btnSubDay.Name = "btnSubDay";
            this.btnSubDay.Size = new System.Drawing.Size(149, 32);
            this.btnSubDay.TabIndex = 5;
            this.btnSubDay.Text = "Sub. Day";
            this.btnSubDay.UseVisualStyleBackColor = true;
            this.btnSubDay.Click += new System.EventHandler(this.btnSubDay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 675);
            this.Controls.Add(this.btnSubDay);
            this.Controls.Add(this.btnAddDay);
            this.Controls.Add(this.dpZaman);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.txtSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.DateTimePicker dpZaman;
        private System.Windows.Forms.Button btnAddDay;
        private System.Windows.Forms.Button btnSubDay;
    }
}

