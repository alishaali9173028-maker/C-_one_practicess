namespace practise
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
            this.textfood1 = new System.Windows.Forms.TextBox();
            this.textprice1 = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblnamefood = new System.Windows.Forms.Label();
            this.lblpriceone = new System.Windows.Forms.Label();
            this.lblfoodtwo = new System.Windows.Forms.Label();
            this.bttcalculate = new System.Windows.Forms.Button();
            this.textfood2 = new System.Windows.Forms.TextBox();
            this.textprice2 = new System.Windows.Forms.TextBox();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textfood1
            // 
            this.textfood1.Location = new System.Drawing.Point(434, 52);
            this.textfood1.Name = "textfood1";
            this.textfood1.Size = new System.Drawing.Size(321, 26);
            this.textfood1.TabIndex = 0;
            // 
            // textprice1
            // 
            this.textprice1.Location = new System.Drawing.Point(434, 120);
            this.textprice1.Name = "textprice1";
            this.textprice1.Size = new System.Drawing.Size(312, 26);
            this.textprice1.TabIndex = 1;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.Color.DarkGray;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(192, 356);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(312, 47);
            this.lbloutput.TabIndex = 2;
            // 
            // lblnamefood
            // 
            this.lblnamefood.Location = new System.Drawing.Point(102, 42);
            this.lblnamefood.Name = "lblnamefood";
            this.lblnamefood.Size = new System.Drawing.Size(244, 36);
            this.lblnamefood.TabIndex = 3;
            this.lblnamefood.Text = "Enter food one";
            this.lblnamefood.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpriceone
            // 
            this.lblpriceone.Location = new System.Drawing.Point(106, 110);
            this.lblpriceone.Name = "lblpriceone";
            this.lblpriceone.Size = new System.Drawing.Size(240, 36);
            this.lblpriceone.TabIndex = 4;
            this.lblpriceone.Text = "Enter price one";
            this.lblpriceone.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblfoodtwo
            // 
            this.lblfoodtwo.Location = new System.Drawing.Point(89, 165);
            this.lblfoodtwo.Name = "lblfoodtwo";
            this.lblfoodtwo.Size = new System.Drawing.Size(223, 47);
            this.lblfoodtwo.TabIndex = 5;
            this.lblfoodtwo.Text = "Enter food two";
            this.lblfoodtwo.Click += new System.EventHandler(this.label3_Click);
            // 
            // bttcalculate
            // 
            this.bttcalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttcalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttcalculate.Location = new System.Drawing.Point(269, 297);
            this.bttcalculate.Name = "bttcalculate";
            this.bttcalculate.Size = new System.Drawing.Size(106, 43);
            this.bttcalculate.TabIndex = 6;
            this.bttcalculate.Text = "calculate";
            this.bttcalculate.UseVisualStyleBackColor = false;
            this.bttcalculate.Click += new System.EventHandler(this.bttcalculate_Click);
            // 
            // textfood2
            // 
            this.textfood2.Location = new System.Drawing.Point(430, 177);
            this.textfood2.Name = "textfood2";
            this.textfood2.Size = new System.Drawing.Size(321, 26);
            this.textfood2.TabIndex = 8;
            // 
            // textprice2
            // 
            this.textprice2.Location = new System.Drawing.Point(434, 248);
            this.textprice2.Name = "textprice2";
            this.textprice2.Size = new System.Drawing.Size(321, 26);
            this.textprice2.TabIndex = 9;
            // 
            // lblprice2
            // 
            this.lblprice2.Location = new System.Drawing.Point(89, 227);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(240, 36);
            this.lblprice2.TabIndex = 10;
            this.lblprice2.Text = "Enter price two";
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbltotal.Location = new System.Drawing.Point(192, 421);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(312, 42);
            this.lbltotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 532);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.textprice2);
            this.Controls.Add(this.textfood2);
            this.Controls.Add(this.bttcalculate);
            this.Controls.Add(this.lblfoodtwo);
            this.Controls.Add(this.lblpriceone);
            this.Controls.Add(this.lblnamefood);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.textprice1);
            this.Controls.Add(this.textfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textfood1;
        private System.Windows.Forms.TextBox textprice1;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblnamefood;
        private System.Windows.Forms.Label lblpriceone;
        private System.Windows.Forms.Label lblfoodtwo;
        private System.Windows.Forms.Button bttcalculate;
        private System.Windows.Forms.TextBox textfood2;
        private System.Windows.Forms.TextBox textprice2;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.Label lbltotal;
    }
}

