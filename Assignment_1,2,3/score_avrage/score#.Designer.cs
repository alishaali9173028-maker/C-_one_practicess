namespace TESTScORE
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
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lblavrage = new System.Windows.Forms.Label();
            this.textscore1 = new System.Windows.Forms.TextBox();
            this.textscore2 = new System.Windows.Forms.TextBox();
            this.textscore3 = new System.Windows.Forms.TextBox();
            this.textavrage = new System.Windows.Forms.TextBox();
            this.bttcalculate = new System.Windows.Forms.Button();
            this.bttclear = new System.Windows.Forms.Button();
            this.bttexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Location = new System.Drawing.Point(165, 59);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(103, 20);
            this.lblscore1.TabIndex = 0;
            this.lblscore1.Text = "text Score 1#";
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Location = new System.Drawing.Point(165, 114);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(103, 20);
            this.lblscore2.TabIndex = 1;
            this.lblscore2.Text = "text Score 2#";
            // 
            // lblscore3
            // 
            this.lblscore3.AutoSize = true;
            this.lblscore3.Location = new System.Drawing.Point(165, 172);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(103, 20);
            this.lblscore3.TabIndex = 2;
            this.lblscore3.Text = "text Score 3#";
            this.lblscore3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblavrage
            // 
            this.lblavrage.AutoSize = true;
            this.lblavrage.Location = new System.Drawing.Point(221, 258);
            this.lblavrage.Name = "lblavrage";
            this.lblavrage.Size = new System.Drawing.Size(68, 20);
            this.lblavrage.TabIndex = 3;
            this.lblavrage.Text = "Average";
            // 
            // textscore1
            // 
            this.textscore1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textscore1.Location = new System.Drawing.Point(419, 56);
            this.textscore1.Name = "textscore1";
            this.textscore1.Size = new System.Drawing.Size(308, 26);
            this.textscore1.TabIndex = 4;
            this.textscore1.TextChanged += new System.EventHandler(this.textscore1_TextChanged);
            // 
            // textscore2
            // 
            this.textscore2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textscore2.Location = new System.Drawing.Point(419, 114);
            this.textscore2.Name = "textscore2";
            this.textscore2.Size = new System.Drawing.Size(308, 26);
            this.textscore2.TabIndex = 5;
            // 
            // textscore3
            // 
            this.textscore3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textscore3.ForeColor = System.Drawing.Color.White;
            this.textscore3.Location = new System.Drawing.Point(419, 166);
            this.textscore3.Name = "textscore3";
            this.textscore3.Size = new System.Drawing.Size(308, 26);
            this.textscore3.TabIndex = 6;
            // 
            // textavrage
            // 
            this.textavrage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textavrage.ForeColor = System.Drawing.SystemColors.Info;
            this.textavrage.Location = new System.Drawing.Point(366, 252);
            this.textavrage.Name = "textavrage";
            this.textavrage.Size = new System.Drawing.Size(258, 26);
            this.textavrage.TabIndex = 7;
            // 
            // bttcalculate
            // 
            this.bttcalculate.BackColor = System.Drawing.Color.Lime;
            this.bttcalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcalculate.ForeColor = System.Drawing.Color.IndianRed;
            this.bttcalculate.Location = new System.Drawing.Point(189, 326);
            this.bttcalculate.Name = "bttcalculate";
            this.bttcalculate.Size = new System.Drawing.Size(137, 93);
            this.bttcalculate.TabIndex = 8;
            this.bttcalculate.Text = "&Calculate avrage";
            this.bttcalculate.UseVisualStyleBackColor = false;
            this.bttcalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttclear
            // 
            this.bttclear.Location = new System.Drawing.Point(366, 326);
            this.bttclear.Name = "bttclear";
            this.bttclear.Size = new System.Drawing.Size(75, 63);
            this.bttclear.TabIndex = 9;
            this.bttclear.Text = "C&leare";
            this.bttclear.UseVisualStyleBackColor = true;
            this.bttclear.Click += new System.EventHandler(this.bttclear_Click);
            // 
            // bttexit
            // 
            this.bttexit.Location = new System.Drawing.Point(464, 345);
            this.bttexit.Name = "bttexit";
            this.bttexit.Size = new System.Drawing.Size(75, 58);
            this.bttexit.TabIndex = 10;
            this.bttexit.Text = "E&xit";
            this.bttexit.UseVisualStyleBackColor = true;
            this.bttexit.Click += new System.EventHandler(this.bttexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 503);
            this.Controls.Add(this.bttexit);
            this.Controls.Add(this.bttclear);
            this.Controls.Add(this.bttcalculate);
            this.Controls.Add(this.textavrage);
            this.Controls.Add(this.textscore3);
            this.Controls.Add(this.textscore2);
            this.Controls.Add(this.textscore1);
            this.Controls.Add(this.lblavrage);
            this.Controls.Add(this.lblscore3);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.lblscore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lblavrage;
        private System.Windows.Forms.TextBox textscore1;
        private System.Windows.Forms.TextBox textscore2;
        private System.Windows.Forms.TextBox textscore3;
        private System.Windows.Forms.TextBox textavrage;
        private System.Windows.Forms.Button bttcalculate;
        private System.Windows.Forms.Button bttclear;
        private System.Windows.Forms.Button bttexit;
    }
}

