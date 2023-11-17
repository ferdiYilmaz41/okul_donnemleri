namespace StringFormat
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
            this.txtFormatlanacakSayi = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnAddDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFormatlanacakSayi
            // 
            this.txtFormatlanacakSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFormatlanacakSayi.Location = new System.Drawing.Point(33, 43);
            this.txtFormatlanacakSayi.Name = "txtFormatlanacakSayi";
            this.txtFormatlanacakSayi.Size = new System.Drawing.Size(360, 45);
            this.txtFormatlanacakSayi.TabIndex = 0;
            this.txtFormatlanacakSayi.Text = "1";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(33, 155);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(947, 489);
            this.txtSonuc.TabIndex = 1;
            // 
            // btnFormat
            // 
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.btnFormat.Location = new System.Drawing.Point(399, 43);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(178, 45);
            this.btnFormat.TabIndex = 2;
            this.btnFormat.Text = "Formatla";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(33, 119);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(360, 30);
            this.dtTarih.TabIndex = 3;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // btnAddDay
            // 
            this.btnAddDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.btnAddDay.Location = new System.Drawing.Point(399, 110);
            this.btnAddDay.Name = "btnAddDay";
            this.btnAddDay.Size = new System.Drawing.Size(178, 45);
            this.btnAddDay.TabIndex = 4;
            this.btnAddDay.Text = "Ekle";
            this.btnAddDay.UseVisualStyleBackColor = true;
            this.btnAddDay.Click += new System.EventHandler(this.btnAddDay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 644);
            this.Controls.Add(this.btnAddDay);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtFormatlanacakSayi);
            this.Name = "Form1";
            this.Text = "Formatla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormatlanacakSayi;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button btnAddDay;
    }
}

