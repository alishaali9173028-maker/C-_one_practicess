namespace payroll_with_overtime
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
            this.lblhouseworke = new System.Windows.Forms.Label();
            this.lblhourlybyrate = new System.Windows.Forms.Label();
            this.lblgroospay = new System.Windows.Forms.Label();
            this.texthouse = new System.Windows.Forms.TextBox();
            this.texthourly = new System.Windows.Forms.TextBox();
            this.textgroos = new System.Windows.Forms.TextBox();
            this.bttcalculate = new System.Windows.Forms.Button();
            this.bttclear = new System.Windows.Forms.Button();
            this.bttexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhouseworke
            // 
            this.lblhouseworke.AutoSize = true;
            this.lblhouseworke.Location = new System.Drawing.Point(133, 70);
            this.lblhouseworke.Name = "lblhouseworke";
            this.lblhouseworke.Size = new System.Drawing.Size(97, 20);
            this.lblhouseworke.TabIndex = 0;
            this.lblhouseworke.Text = "House Work";
            // 
            // lblhourlybyrate
            // 
            this.lblhourlybyrate.AutoSize = true;
            this.lblhourlybyrate.Location = new System.Drawing.Point(133, 150);
            this.lblhourlybyrate.Name = "lblhourlybyrate";
            this.lblhourlybyrate.Size = new System.Drawing.Size(116, 20);
            this.lblhourlybyrate.TabIndex = 1;
            this.lblhourlybyrate.Text = "Hourly Pay rate";
            // 
            // lblgroospay
            // 
            this.lblgroospay.AutoSize = true;
            this.lblgroospay.Location = new System.Drawing.Point(133, 228);
            this.lblgroospay.Name = "lblgroospay";
            this.lblgroospay.Size = new System.Drawing.Size(77, 20);
            this.lblgroospay.TabIndex = 2;
            this.lblgroospay.Text = "gross pay";
            this.lblgroospay.Click += new System.EventHandler(this.label3_Click);
            // 
            // texthouse
            // 
            this.texthouse.Location = new System.Drawing.Point(408, 64);
            this.texthouse.Name = "texthouse";
            this.texthouse.Size = new System.Drawing.Size(275, 26);
            this.texthouse.TabIndex = 3;
            // 
            // texthourly
            // 
            this.texthourly.Location = new System.Drawing.Point(408, 150);
            this.texthourly.Name = "texthourly";
            this.texthourly.Size = new System.Drawing.Size(275, 26);
            this.texthourly.TabIndex = 4;
            // 
            // textgroos
            // 
            this.textgroos.Location = new System.Drawing.Point(408, 237);
            this.textgroos.Name = "textgroos";
            this.textgroos.Size = new System.Drawing.Size(275, 26);
            this.textgroos.TabIndex = 5;
            // 
            // bttcalculate
            // 
            this.bttcalculate.Location = new System.Drawing.Point(167, 311);
            this.bttcalculate.Name = "bttcalculate";
            this.bttcalculate.Size = new System.Drawing.Size(124, 63);
            this.bttcalculate.TabIndex = 6;
            this.bttcalculate.Text = "C&alaculate GROSS by";
            this.bttcalculate.UseVisualStyleBackColor = true;
            this.bttcalculate.Click += new System.EventHandler(this.bttcalculate_Click);
            // 
            // bttclear
            // 
            this.bttclear.Location = new System.Drawing.Point(333, 316);
            this.bttclear.Name = "bttclear";
            this.bttclear.Size = new System.Drawing.Size(100, 58);
            this.bttclear.TabIndex = 7;
            this.bttclear.Text = "&Clear";
            this.bttclear.UseVisualStyleBackColor = true;
            this.bttclear.Click += new System.EventHandler(this.bttclear_Click);
            // 
            // bttexit
            // 
            this.bttexit.Location = new System.Drawing.Point(469, 331);
            this.bttexit.Name = "bttexit";
            this.bttexit.Size = new System.Drawing.Size(89, 43);
            this.bttexit.TabIndex = 8;
            this.bttexit.Text = "E&xit";
            this.bttexit.UseVisualStyleBackColor = true;
            this.bttexit.Click += new System.EventHandler(this.bttexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttexit);
            this.Controls.Add(this.bttclear);
            this.Controls.Add(this.bttcalculate);
            this.Controls.Add(this.textgroos);
            this.Controls.Add(this.texthourly);
            this.Controls.Add(this.texthouse);
            this.Controls.Add(this.lblgroospay);
            this.Controls.Add(this.lblhourlybyrate);
            this.Controls.Add(this.lblhouseworke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhouseworke;
        private System.Windows.Forms.Label lblhourlybyrate;
        private System.Windows.Forms.Label lblgroospay;
        private System.Windows.Forms.TextBox texthouse;
        private System.Windows.Forms.TextBox texthourly;
        private System.Windows.Forms.TextBox textgroos;
        private System.Windows.Forms.Button bttcalculate;
        private System.Windows.Forms.Button bttclear;
        private System.Windows.Forms.Button bttexit;
    }
}

