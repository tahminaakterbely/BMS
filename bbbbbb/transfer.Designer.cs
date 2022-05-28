namespace bbbbbb
{
    partial class transfer
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.totxt = new System.Windows.Forms.TextBox();
            this.ftxt = new System.Windows.Forms.TextBox();
            this.txtde = new System.Windows.Forms.Label();
            this.txtbal = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            this.txtacc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.totxt);
            this.groupBox1.Controls.Add(this.ftxt);
            this.groupBox1.Controls.Add(this.txtde);
            this.groupBox1.Controls.Add(this.txtbal);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtacc);
            this.groupBox1.Location = new System.Drawing.Point(177, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account to Account transaction";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(179, 185);
            this.txtamount.Multiline = true;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(200, 41);
            this.txtamount.TabIndex = 2;
            // 
            // totxt
            // 
            this.totxt.Location = new System.Drawing.Point(179, 138);
            this.totxt.Multiline = true;
            this.totxt.Name = "totxt";
            this.totxt.Size = new System.Drawing.Size(200, 41);
            this.totxt.TabIndex = 2;
            // 
            // ftxt
            // 
            this.ftxt.Location = new System.Drawing.Point(179, 49);
            this.ftxt.Multiline = true;
            this.ftxt.Name = "ftxt";
            this.ftxt.Size = new System.Drawing.Size(200, 40);
            this.ftxt.TabIndex = 2;
            // 
            // txtde
            // 
            this.txtde.AutoSize = true;
            this.txtde.Location = new System.Drawing.Point(6, 208);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(43, 13);
            this.txtde.TabIndex = 1;
            this.txtde.Text = "Amount";
            // 
            // txtbal
            // 
            this.txtbal.AutoSize = true;
            this.txtbal.Location = new System.Drawing.Point(45, 155);
            this.txtbal.Name = "txtbal";
            this.txtbal.Size = new System.Drawing.Size(56, 13);
            this.txtbal.TabIndex = 1;
            this.txtbal.Text = "To_accno";
            // 
            // txtdate
            // 
            this.txtdate.AutoSize = true;
            this.txtdate.Location = new System.Drawing.Point(45, 93);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(30, 13);
            this.txtdate.TabIndex = 1;
            this.txtdate.Text = "Date";
            // 
            // txtacc
            // 
            this.txtacc.AutoSize = true;
            this.txtacc.Location = new System.Drawing.Point(45, 52);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(66, 13);
            this.txtacc.TabIndex = 0;
            this.txtacc.Text = "From_accno";
            // 
            // transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transfer";
            this.Text = "transfer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox totxt;
        private System.Windows.Forms.TextBox ftxt;
        private System.Windows.Forms.Label txtde;
        private System.Windows.Forms.Label txtbal;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Label txtacc;
    }
}