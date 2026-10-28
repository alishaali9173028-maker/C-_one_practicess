namespace software_sales
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textnumber = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttcalculate = new System.Windows.Forms.Button();
            this.buttclear = new System.Windows.Forms.Button();
            this.buttexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 213);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of packages   :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price per package   :";
            // 
            // textnumber
            // 
            this.textnumber.Location = new System.Drawing.Point(296, 58);
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(229, 26);
            this.textnumber.TabIndex = 4;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(296, 153);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(229, 26);
            this.textprice.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(591, -2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 484);
            this.listBox1.TabIndex = 6;
            // 
            // buttcalculate
            // 
            this.buttcalculate.BackColor = System.Drawing.Color.Lime;
            this.buttcalculate.Location = new System.Drawing.Point(29, 324);
            this.buttcalculate.Name = "buttcalculate";
            this.buttcalculate.Size = new System.Drawing.Size(125, 59);
            this.buttcalculate.TabIndex = 8;
            this.buttcalculate.Text = "Calculate";
            this.buttcalculate.UseVisualStyleBackColor = false;
            this.buttcalculate.Click += new System.EventHandler(this.buttcalculate_Click);
            // 
            // buttclear
            // 
            this.buttclear.BackColor = System.Drawing.Color.Red;
            this.buttclear.Location = new System.Drawing.Point(212, 324);
            this.buttclear.Name = "buttclear";
            this.buttclear.Size = new System.Drawing.Size(125, 59);
            this.buttclear.TabIndex = 9;
            this.buttclear.Text = "Clear";
            this.buttclear.UseVisualStyleBackColor = false;
            this.buttclear.Click += new System.EventHandler(this.buttclear_Click);
            // 
            // buttexit
            // 
            this.buttexit.BackColor = System.Drawing.Color.Yellow;
            this.buttexit.Location = new System.Drawing.Point(400, 324);
            this.buttexit.Name = "buttexit";
            this.buttexit.Size = new System.Drawing.Size(125, 59);
            this.buttexit.TabIndex = 10;
            this.buttexit.Text = "Exit";
            this.buttexit.UseVisualStyleBackColor = false;
            this.buttexit.Click += new System.EventHandler(this.buttexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 542);
            this.Controls.Add(this.buttexit);
            this.Controls.Add(this.buttclear);
            this.Controls.Add(this.buttcalculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttcalculate;
        private System.Windows.Forms.Button buttclear;
        private System.Windows.Forms.Button buttexit;
    }
}

