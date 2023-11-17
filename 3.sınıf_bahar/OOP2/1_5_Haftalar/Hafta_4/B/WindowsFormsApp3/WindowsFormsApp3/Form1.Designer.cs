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
            this.mnCalender = new System.Windows.Forms.MonthCalendar();
            this.btnSecimDegistir = new System.Windows.Forms.Button();
            this.lbTarBas = new System.Windows.Forms.Label();
            this.lbTarBit = new System.Windows.Forms.Label();
            this.lbGun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mnCalender
            // 
            this.mnCalender.Location = new System.Drawing.Point(13, 13);
            this.mnCalender.MaxSelectionCount = 4;
            this.mnCalender.Name = "mnCalender";
            this.mnCalender.TabIndex = 0;
            this.mnCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mnCalender_DateChanged);
            // 
            // btnSecimDegistir
            // 
            this.btnSecimDegistir.Location = new System.Drawing.Point(12, 232);
            this.btnSecimDegistir.Name = "btnSecimDegistir";
            this.btnSecimDegistir.Size = new System.Drawing.Size(285, 45);
            this.btnSecimDegistir.TabIndex = 1;
            this.btnSecimDegistir.Text = "Maks Gün Değiştir";
            this.btnSecimDegistir.UseVisualStyleBackColor = true;
            this.btnSecimDegistir.Click += new System.EventHandler(this.btnSecimDegistir_Click);
            // 
            // lbTarBas
            // 
            this.lbTarBas.AutoSize = true;
            this.lbTarBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTarBas.Location = new System.Drawing.Point(354, 27);
            this.lbTarBas.Name = "lbTarBas";
            this.lbTarBas.Size = new System.Drawing.Size(22, 32);
            this.lbTarBas.TabIndex = 2;
            this.lbTarBas.Text = " ";
            // 
            // lbTarBit
            // 
            this.lbTarBit.AutoSize = true;
            this.lbTarBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTarBit.Location = new System.Drawing.Point(354, 64);
            this.lbTarBit.Name = "lbTarBit";
            this.lbTarBit.Size = new System.Drawing.Size(22, 32);
            this.lbTarBit.TabIndex = 3;
            this.lbTarBit.Text = " ";
            // 
            // lbGun
            // 
            this.lbGun.AutoSize = true;
            this.lbGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbGun.Location = new System.Drawing.Point(354, 96);
            this.lbGun.Name = "lbGun";
            this.lbGun.Size = new System.Drawing.Size(22, 32);
            this.lbGun.TabIndex = 4;
            this.lbGun.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbGun);
            this.Controls.Add(this.lbTarBit);
            this.Controls.Add(this.lbTarBas);
            this.Controls.Add(this.btnSecimDegistir);
            this.Controls.Add(this.mnCalender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mnCalender;
        private System.Windows.Forms.Button btnSecimDegistir;
        private System.Windows.Forms.Label lbTarBas;
        private System.Windows.Forms.Label lbTarBit;
        private System.Windows.Forms.Label lbGun;
    }
}

