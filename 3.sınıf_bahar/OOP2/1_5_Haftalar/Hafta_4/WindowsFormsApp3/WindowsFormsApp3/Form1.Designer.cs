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
            this.lbTarBas = new System.Windows.Forms.Label();
            this.lbTarBit = new System.Windows.Forms.Label();
            this.btnMaksSelection = new System.Windows.Forms.Button();
            this.lbTimeSpan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mnCalender
            // 
            this.mnCalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mnCalender.Location = new System.Drawing.Point(6, 7);
            this.mnCalender.MaxSelectionCount = 15;
            this.mnCalender.Name = "mnCalender";
            this.mnCalender.TabIndex = 0;
            this.mnCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mnCalender_DateChanged);
            // 
            // lbTarBas
            // 
            this.lbTarBas.AutoSize = true;
            this.lbTarBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTarBas.Location = new System.Drawing.Point(332, 7);
            this.lbTarBas.Name = "lbTarBas";
            this.lbTarBas.Size = new System.Drawing.Size(0, 32);
            this.lbTarBas.TabIndex = 1;
            // 
            // lbTarBit
            // 
            this.lbTarBit.AutoSize = true;
            this.lbTarBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTarBit.Location = new System.Drawing.Point(332, 42);
            this.lbTarBit.Name = "lbTarBit";
            this.lbTarBit.Size = new System.Drawing.Size(0, 32);
            this.lbTarBit.TabIndex = 2;
            // 
            // btnMaksSelection
            // 
            this.btnMaksSelection.Location = new System.Drawing.Point(6, 226);
            this.btnMaksSelection.Name = "btnMaksSelection";
            this.btnMaksSelection.Size = new System.Drawing.Size(262, 32);
            this.btnMaksSelection.TabIndex = 3;
            this.btnMaksSelection.Text = "Maks Seçim";
            this.btnMaksSelection.UseVisualStyleBackColor = true;
            this.btnMaksSelection.Click += new System.EventHandler(this.btnMaksSelection_Click);
            // 
            // lbTimeSpan
            // 
            this.lbTimeSpan.AutoSize = true;
            this.lbTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbTimeSpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTimeSpan.Location = new System.Drawing.Point(332, 96);
            this.lbTimeSpan.Name = "lbTimeSpan";
            this.lbTimeSpan.Size = new System.Drawing.Size(0, 32);
            this.lbTimeSpan.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTimeSpan);
            this.Controls.Add(this.btnMaksSelection);
            this.Controls.Add(this.lbTarBit);
            this.Controls.Add(this.lbTarBas);
            this.Controls.Add(this.mnCalender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mnCalender;
        private System.Windows.Forms.Label lbTarBas;
        private System.Windows.Forms.Label lbTarBit;
        private System.Windows.Forms.Button btnMaksSelection;
        private System.Windows.Forms.Label lbTimeSpan;
    }
}

