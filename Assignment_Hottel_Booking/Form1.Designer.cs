namespace Bookinghottel
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
            this.components = new System.ComponentModel.Container();
            this.textname = new System.Windows.Forms.TextBox();
            this.textnightes = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textroom = new System.Windows.Forms.TextBox();
            this.lblnameguest = new System.Windows.Forms.Label();
            this.lblroom = new System.Windows.Forms.Label();
            this.lblnight = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.texttax = new System.Windows.Forms.TextBox();
            this.textdescount = new System.Windows.Forms.TextBox();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.bttcalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(465, 37);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(299, 26);
            this.textname.TabIndex = 0;
            // 
            // textnightes
            // 
            this.textnightes.Location = new System.Drawing.Point(465, 145);
            this.textnightes.Name = "textnightes";
            this.textnightes.Size = new System.Drawing.Size(299, 26);
            this.textnightes.TabIndex = 1;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(465, 205);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(299, 26);
            this.textprice.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textroom
            // 
            this.textroom.Location = new System.Drawing.Point(465, 93);
            this.textroom.Name = "textroom";
            this.textroom.Size = new System.Drawing.Size(299, 26);
            this.textroom.TabIndex = 4;
            // 
            // lblnameguest
            // 
            this.lblnameguest.Location = new System.Drawing.Point(190, 43);
            this.lblnameguest.Name = "lblnameguest";
            this.lblnameguest.Size = new System.Drawing.Size(207, 23);
            this.lblnameguest.TabIndex = 6;
            this.lblnameguest.Text = "Enter the guest name";
            // 
            // lblroom
            // 
            this.lblroom.Location = new System.Drawing.Point(190, 96);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(207, 23);
            this.lblroom.TabIndex = 7;
            this.lblroom.Text = "Enter the room typ";
            // 
            // lblnight
            // 
            this.lblnight.Location = new System.Drawing.Point(190, 148);
            this.lblnight.Name = "lblnight";
            this.lblnight.Size = new System.Drawing.Size(207, 26);
            this.lblnight.TabIndex = 8;
            this.lblnight.Text = "Enter numbers of nightes";
            // 
            // lblprice
            // 
            this.lblprice.Location = new System.Drawing.Point(190, 205);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(207, 26);
            this.lblprice.TabIndex = 9;
            this.lblprice.Text = "Enter price per night";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(108, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 160);
            this.label2.TabIndex = 11;
            // 
            // lbltax
            // 
            this.lbltax.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltax.ForeColor = System.Drawing.SystemColors.Window;
            this.lbltax.Location = new System.Drawing.Point(147, 367);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(177, 23);
            this.lbltax.TabIndex = 12;
            this.lbltax.Text = "service tax (10%)";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbldiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldiscount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbldiscount.Location = new System.Drawing.Point(147, 415);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(115, 20);
            this.lbldiscount.TabIndex = 14;
            this.lbldiscount.Text = "Descount (5%)";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbltotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbltotal.Location = new System.Drawing.Point(147, 461);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(111, 20);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "Total amounth";
            // 
            // texttax
            // 
            this.texttax.Location = new System.Drawing.Point(500, 364);
            this.texttax.Name = "texttax";
            this.texttax.Size = new System.Drawing.Size(275, 26);
            this.texttax.TabIndex = 16;
            // 
            // textdescount
            // 
            this.textdescount.Location = new System.Drawing.Point(500, 415);
            this.textdescount.Name = "textdescount";
            this.textdescount.Size = new System.Drawing.Size(275, 26);
            this.textdescount.TabIndex = 17;
            // 
            // texttotal
            // 
            this.texttotal.Location = new System.Drawing.Point(500, 461);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(275, 26);
            this.texttotal.TabIndex = 18;
            // 
            // bttcalculate
            // 
            this.bttcalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttcalculate.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcalculate.ForeColor = System.Drawing.Color.White;
            this.bttcalculate.Location = new System.Drawing.Point(348, 260);
            this.bttcalculate.Name = "bttcalculate";
            this.bttcalculate.Size = new System.Drawing.Size(206, 55);
            this.bttcalculate.TabIndex = 19;
            this.bttcalculate.Text = "Calculate";
            this.bttcalculate.UseVisualStyleBackColor = false;
            this.bttcalculate.Click += new System.EventHandler(this.bttcalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 516);
            this.Controls.Add(this.bttcalculate);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.textdescount);
            this.Controls.Add(this.texttax);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblnight);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.lblnameguest);
            this.Controls.Add(this.textroom);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textnightes);
            this.Controls.Add(this.textname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textnightes;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textroom;
        private System.Windows.Forms.Label lblnameguest;
        private System.Windows.Forms.Label lblroom;
        private System.Windows.Forms.Label lblnight;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox texttax;
        private System.Windows.Forms.TextBox textdescount;
        private System.Windows.Forms.TextBox texttotal;
        private System.Windows.Forms.Button bttcalculate;
    }
}

