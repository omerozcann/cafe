namespace cafe
{
    partial class satisFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.adettxt = new System.Windows.Forms.TextBox();
            this.uruncmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.satislst = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masatxt = new System.Windows.Forms.TextBox();
            this.listelebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet";
            // 
            // adettxt
            // 
            this.adettxt.Location = new System.Drawing.Point(49, 14);
            this.adettxt.Name = "adettxt";
            this.adettxt.Size = new System.Drawing.Size(121, 20);
            this.adettxt.TabIndex = 1;
            // 
            // uruncmb
            // 
            this.uruncmb.FormattingEnabled = true;
            this.uruncmb.Location = new System.Drawing.Point(49, 40);
            this.uruncmb.Name = "uruncmb";
            this.uruncmb.Size = new System.Drawing.Size(121, 21);
            this.uruncmb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(193, 12);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 4;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // satislst
            // 
            this.satislst.FormattingEnabled = true;
            this.satislst.Location = new System.Drawing.Point(17, 93);
            this.satislst.Name = "satislst";
            this.satislst.Size = new System.Drawing.Size(251, 160);
            this.satislst.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Masa";
            // 
            // masatxt
            // 
            this.masatxt.Location = new System.Drawing.Point(49, 67);
            this.masatxt.Name = "masatxt";
            this.masatxt.ReadOnly = true;
            this.masatxt.Size = new System.Drawing.Size(121, 20);
            this.masatxt.TabIndex = 8;
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(193, 43);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 45);
            this.listelebtn.TabIndex = 5;
            this.listelebtn.Text = "Hesabı Kapat";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // satisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 269);
            this.Controls.Add(this.masatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.satislst);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uruncmb);
            this.Controls.Add(this.adettxt);
            this.Controls.Add(this.label1);
            this.Name = "satisFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adettxt;
        private System.Windows.Forms.ComboBox uruncmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.ListBox satislst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox masatxt;
        private System.Windows.Forms.Button listelebtn;
    }
}