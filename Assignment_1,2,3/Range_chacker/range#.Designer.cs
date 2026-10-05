namespace application
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
            this.textinteger = new System.Windows.Forms.TextBox();
            this.lbrangecheckapp = new System.Windows.Forms.Label();
            this.lbldesion = new System.Windows.Forms.Label();
            this.textrangedecision = new System.Windows.Forms.TextBox();
            this.lblinteger = new System.Windows.Forms.Label();
            this.bttcheck = new System.Windows.Forms.Button();
            this.bttclear = new System.Windows.Forms.Button();
            this.bttexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textinteger
            // 
            this.textinteger.Location = new System.Drawing.Point(182, 130);
            this.textinteger.Name = "textinteger";
            this.textinteger.Size = new System.Drawing.Size(371, 26);
            this.textinteger.TabIndex = 0;
            this.textinteger.TextChanged += new System.EventHandler(this.textinteger_TextChanged);
            // 
            // lbrangecheckapp
            // 
            this.lbrangecheckapp.AutoSize = true;
            this.lbrangecheckapp.Location = new System.Drawing.Point(241, 9);
            this.lbrangecheckapp.Name = "lbrangecheckapp";
            this.lbrangecheckapp.Size = new System.Drawing.Size(202, 20);
            this.lbrangecheckapp.TabIndex = 1;
            this.lbrangecheckapp.Text = "Range Checker Application\n";
            // 
            // lbldesion
            // 
            this.lbldesion.AutoSize = true;
            this.lbldesion.Location = new System.Drawing.Point(281, 180);
            this.lbldesion.Name = "lbldesion";
            this.lbldesion.Size = new System.Drawing.Size(122, 20);
            this.lbldesion.TabIndex = 2;
            this.lbldesion.Text = "Range Decision\n";
            // 
            // textrangedecision
            // 
            this.textrangedecision.Location = new System.Drawing.Point(193, 240);
            this.textrangedecision.Name = "textrangedecision";
            this.textrangedecision.Size = new System.Drawing.Size(371, 26);
            this.textrangedecision.TabIndex = 3;
            this.textrangedecision.TextChanged += new System.EventHandler(this.textrangedecision_TextChanged);
            // 
            // lblinteger
            // 
            this.lblinteger.Location = new System.Drawing.Point(241, 77);
            this.lblinteger.Name = "lblinteger";
            this.lblinteger.Size = new System.Drawing.Size(323, 35);
            this.lblinteger.TabIndex = 4;
            this.lblinteger.Text = "Enter an integer in the range of 1 throught 10\n";
            // 
            // bttcheck
            // 
            this.bttcheck.Location = new System.Drawing.Point(154, 311);
            this.bttcheck.Name = "bttcheck";
            this.bttcheck.Size = new System.Drawing.Size(75, 50);
            this.bttcheck.TabIndex = 5;
            this.bttcheck.Text = "C&heck Qualfication\n";
            this.bttcheck.UseVisualStyleBackColor = true;
            this.bttcheck.Click += new System.EventHandler(this.bttcheck_Click);
            // 
            // bttclear
            // 
            this.bttclear.Location = new System.Drawing.Point(305, 311);
            this.bttclear.Name = "bttclear";
            this.bttclear.Size = new System.Drawing.Size(75, 50);
            this.bttclear.TabIndex = 6;
            this.bttclear.Text = "&Clear";
            this.bttclear.UseVisualStyleBackColor = true;
            this.bttclear.Click += new System.EventHandler(this.bttclear_Click);
            // 
            // bttexit
            // 
            this.bttexit.Location = new System.Drawing.Point(438, 324);
            this.bttexit.Name = "bttexit";
            this.bttexit.Size = new System.Drawing.Size(75, 37);
            this.bttexit.TabIndex = 7;
            this.bttexit.Text = "E&xit";
            this.bttexit.UseVisualStyleBackColor = true;
            this.bttexit.Click += new System.EventHandler(this.bttexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 452);
            this.Controls.Add(this.bttexit);
            this.Controls.Add(this.bttclear);
            this.Controls.Add(this.bttcheck);
            this.Controls.Add(this.lblinteger);
            this.Controls.Add(this.textrangedecision);
            this.Controls.Add(this.lbldesion);
            this.Controls.Add(this.lbrangecheckapp);
            this.Controls.Add(this.textinteger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textinteger;
        private System.Windows.Forms.Label lbrangecheckapp;
        private System.Windows.Forms.Label lbldesion;
        private System.Windows.Forms.TextBox textrangedecision;
        private System.Windows.Forms.Label lblinteger;
        private System.Windows.Forms.Button bttcheck;
        private System.Windows.Forms.Button bttclear;
        private System.Windows.Forms.Button bttexit;
    }
}

