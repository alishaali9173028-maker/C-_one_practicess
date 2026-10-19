namespace studentuni
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
            this.lblsname = new System.Windows.Forms.Label();
            this.textesname = new System.Windows.Forms.TextBox();
            this.textsid = new System.Windows.Forms.TextBox();
            this.textnameofcourse = new System.Windows.Forms.TextBox();
            this.textstudentlevel = new System.Windows.Forms.TextBox();
            this.texttransport = new System.Windows.Forms.TextBox();
            this.lblsid = new System.Windows.Forms.Label();
            this.lblnameofcourse = new System.Windows.Forms.Label();
            this.lblstudentlevel = new System.Windows.Forms.Label();
            this.lbltransport = new System.Windows.Forms.Label();
            this.bttcalculate = new System.Windows.Forms.Button();
            this.bttclear = new System.Windows.Forms.Button();
            this.bttexit = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsname
            // 
            this.lblsname.Location = new System.Drawing.Point(60, 34);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(288, 26);
            this.lblsname.TabIndex = 0;
            this.lblsname.Text = "Student Name";
            // 
            // textesname
            // 
            this.textesname.Location = new System.Drawing.Point(437, 34);
            this.textesname.Name = "textesname";
            this.textesname.Size = new System.Drawing.Size(261, 26);
            this.textesname.TabIndex = 1;
            this.textesname.TextChanged += new System.EventHandler(this.textesname_TextChanged);
            // 
            // textsid
            // 
            this.textsid.Location = new System.Drawing.Point(437, 86);
            this.textsid.Name = "textsid";
            this.textsid.Size = new System.Drawing.Size(261, 26);
            this.textsid.TabIndex = 2;
            this.textsid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textnameofcourse
            // 
            this.textnameofcourse.Location = new System.Drawing.Point(437, 143);
            this.textnameofcourse.Name = "textnameofcourse";
            this.textnameofcourse.Size = new System.Drawing.Size(261, 26);
            this.textnameofcourse.TabIndex = 3;
            this.textnameofcourse.TextChanged += new System.EventHandler(this.textnameofcourse_TextChanged);
            // 
            // textstudentlevel
            // 
            this.textstudentlevel.Location = new System.Drawing.Point(437, 203);
            this.textstudentlevel.Name = "textstudentlevel";
            this.textstudentlevel.Size = new System.Drawing.Size(261, 26);
            this.textstudentlevel.TabIndex = 4;
            this.textstudentlevel.TextChanged += new System.EventHandler(this.textstudentlevel_TextChanged);
            // 
            // texttransport
            // 
            this.texttransport.Location = new System.Drawing.Point(437, 270);
            this.texttransport.Name = "texttransport";
            this.texttransport.Size = new System.Drawing.Size(261, 26);
            this.texttransport.TabIndex = 6;
            this.texttransport.TextChanged += new System.EventHandler(this.texttransport_TextChanged);
            // 
            // lblsid
            // 
            this.lblsid.Location = new System.Drawing.Point(60, 89);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(288, 26);
            this.lblsid.TabIndex = 7;
            this.lblsid.Text = "Student Id";
            // 
            // lblnameofcourse
            // 
            this.lblnameofcourse.Location = new System.Drawing.Point(60, 146);
            this.lblnameofcourse.Name = "lblnameofcourse";
            this.lblnameofcourse.Size = new System.Drawing.Size(288, 26);
            this.lblnameofcourse.TabIndex = 8;
            this.lblnameofcourse.Text = "Name OF Course";
            // 
            // lblstudentlevel
            // 
            this.lblstudentlevel.Location = new System.Drawing.Point(60, 203);
            this.lblstudentlevel.Name = "lblstudentlevel";
            this.lblstudentlevel.Size = new System.Drawing.Size(288, 26);
            this.lblstudentlevel.TabIndex = 9;
            this.lblstudentlevel.Text = "Student Level";
            // 
            // lbltransport
            // 
            this.lbltransport.Location = new System.Drawing.Point(39, 255);
            this.lbltransport.Name = "lbltransport";
            this.lbltransport.Size = new System.Drawing.Size(156, 26);
            this.lbltransport.TabIndex = 11;
            this.lbltransport.Text = "Transport fee";
            // 
            // bttcalculate
            // 
            this.bttcalculate.Location = new System.Drawing.Point(113, 528);
            this.bttcalculate.Name = "bttcalculate";
            this.bttcalculate.Size = new System.Drawing.Size(137, 57);
            this.bttcalculate.TabIndex = 12;
            this.bttcalculate.Text = "&Calculate";
            this.bttcalculate.UseVisualStyleBackColor = true;
            this.bttcalculate.Click += new System.EventHandler(this.bttcalculate_Click);
            // 
            // bttclear
            // 
            this.bttclear.Location = new System.Drawing.Point(301, 528);
            this.bttclear.Name = "bttclear";
            this.bttclear.Size = new System.Drawing.Size(137, 57);
            this.bttclear.TabIndex = 13;
            this.bttclear.Text = "C&lear";
            this.bttclear.UseVisualStyleBackColor = true;
            this.bttclear.Click += new System.EventHandler(this.bttclear_Click);
            // 
            // bttexit
            // 
            this.bttexit.Location = new System.Drawing.Point(491, 528);
            this.bttexit.Name = "bttexit";
            this.bttexit.Size = new System.Drawing.Size(137, 57);
            this.bttexit.TabIndex = 14;
            this.bttexit.Text = "&EXit";
            this.bttexit.UseVisualStyleBackColor = true;
            this.bttexit.Click += new System.EventHandler(this.bttexit_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(43, 319);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(697, 206);
            this.lbloutput.TabIndex = 15;
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 597);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.bttexit);
            this.Controls.Add(this.bttclear);
            this.Controls.Add(this.bttcalculate);
            this.Controls.Add(this.lbltransport);
            this.Controls.Add(this.lblstudentlevel);
            this.Controls.Add(this.lblnameofcourse);
            this.Controls.Add(this.lblsid);
            this.Controls.Add(this.texttransport);
            this.Controls.Add(this.textstudentlevel);
            this.Controls.Add(this.textnameofcourse);
            this.Controls.Add(this.textsid);
            this.Controls.Add(this.textesname);
            this.Controls.Add(this.lblsname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.TextBox textesname;
        private System.Windows.Forms.TextBox textsid;
        private System.Windows.Forms.TextBox textnameofcourse;
        private System.Windows.Forms.TextBox textstudentlevel;
        private System.Windows.Forms.TextBox texttransport;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label lblnameofcourse;
        private System.Windows.Forms.Label lblstudentlevel;
        private System.Windows.Forms.Label lbltransport;
        private System.Windows.Forms.Button bttcalculate;
        private System.Windows.Forms.Button bttclear;
        private System.Windows.Forms.Button bttexit;
        private System.Windows.Forms.Label lbloutput;
    }
}

