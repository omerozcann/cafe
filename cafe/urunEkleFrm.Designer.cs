namespace cafe
{
    partial class urunEkleFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.turcmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aditxt = new System.Windows.Forms.TextBox();
            this.adettxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fiyattxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urunlerdgv = new System.Windows.Forms.DataGridView();
            this.listelebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listelebtn);
            this.groupBox1.Controls.Add(this.kaydetbtn);
            this.groupBox1.Controls.Add(this.fiyattxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.adettxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.aditxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.turcmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türü";
            // 
            // turcmb
            // 
            this.turcmb.FormattingEnabled = true;
            this.turcmb.Items.AddRange(new object[] {
            "İçecek",
            "Yiyecek",
            "Tatlı"});
            this.turcmb.Location = new System.Drawing.Point(75, 45);
            this.turcmb.Name = "turcmb";
            this.turcmb.Size = new System.Drawing.Size(251, 24);
            this.turcmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı";
            // 
            // aditxt
            // 
            this.aditxt.Location = new System.Drawing.Point(75, 85);
            this.aditxt.Name = "aditxt";
            this.aditxt.Size = new System.Drawing.Size(251, 22);
            this.aditxt.TabIndex = 3;
            // 
            // adettxt
            // 
            this.adettxt.Location = new System.Drawing.Point(75, 121);
            this.adettxt.Name = "adettxt";
            this.adettxt.Size = new System.Drawing.Size(251, 22);
            this.adettxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adet";
            // 
            // fiyattxt
            // 
            this.fiyattxt.Location = new System.Drawing.Point(75, 159);
            this.fiyattxt.Name = "fiyattxt";
            this.fiyattxt.Size = new System.Drawing.Size(251, 22);
            this.fiyattxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(251, 197);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 8;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.urunlerdgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Ürünler";
            // 
            // urunlerdgv
            // 
            this.urunlerdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunlerdgv.Location = new System.Drawing.Point(3, 18);
            this.urunlerdgv.Name = "urunlerdgv";
            this.urunlerdgv.RowHeadersWidth = 62;
            this.urunlerdgv.RowTemplate.Height = 24;
            this.urunlerdgv.Size = new System.Drawing.Size(352, 212);
            this.urunlerdgv.TabIndex = 0;
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(170, 197);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 23);
            this.listelebtn.TabIndex = 9;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // urunEkleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "urunEkleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.TextBox fiyattxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adettxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aditxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox turcmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView urunlerdgv;
        private System.Windows.Forms.Button listelebtn;
    }
}