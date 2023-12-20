namespace cafe
{
    partial class cafeFrms
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.masalarcmb = new System.Windows.Forms.ComboBox();
            this.yenimasaeklebtn = new System.Windows.Forms.Button();
            this.uyonetbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.masalarlst = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masalarcmb);
            this.groupBox1.Controls.Add(this.yenimasaeklebtn);
            this.groupBox1.Controls.Add(this.uyonetbtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(700, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontroller";
            // 
            // masalarcmb
            // 
            this.masalarcmb.FormattingEnabled = true;
            this.masalarcmb.Items.AddRange(new object[] {
            "Masa1",
            "Masa2",
            "Masa3",
            "Masa4",
            "Masa5",
            "Masa6",
            "Masa7",
            "Masa8"});
            this.masalarcmb.Location = new System.Drawing.Point(498, 32);
            this.masalarcmb.Name = "masalarcmb";
            this.masalarcmb.Size = new System.Drawing.Size(89, 21);
            this.masalarcmb.TabIndex = 2;
            // 
            // yenimasaeklebtn
            // 
            this.yenimasaeklebtn.Location = new System.Drawing.Point(592, 27);
            this.yenimasaeklebtn.Margin = new System.Windows.Forms.Padding(2);
            this.yenimasaeklebtn.Name = "yenimasaeklebtn";
            this.yenimasaeklebtn.Size = new System.Drawing.Size(95, 28);
            this.yenimasaeklebtn.TabIndex = 1;
            this.yenimasaeklebtn.Text = "Yeni Masa Ekle";
            this.yenimasaeklebtn.UseVisualStyleBackColor = true;
            this.yenimasaeklebtn.Click += new System.EventHandler(this.yenimasaeklebtn_Click);
            // 
            // uyonetbtn
            // 
            this.uyonetbtn.Location = new System.Drawing.Point(16, 27);
            this.uyonetbtn.Margin = new System.Windows.Forms.Padding(2);
            this.uyonetbtn.Name = "uyonetbtn";
            this.uyonetbtn.Size = new System.Drawing.Size(95, 28);
            this.uyonetbtn.TabIndex = 0;
            this.uyonetbtn.Text = "Ürünleri Yönet";
            this.uyonetbtn.UseVisualStyleBackColor = true;
            this.uyonetbtn.Click += new System.EventHandler(this.uyonetbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.masalarlst);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(700, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masalar";
            // 
            // masalarlst
            // 
            this.masalarlst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masalarlst.HideSelection = false;
            this.masalarlst.Location = new System.Drawing.Point(2, 15);
            this.masalarlst.Margin = new System.Windows.Forms.Padding(2);
            this.masalarlst.Name = "masalarlst";
            this.masalarlst.Size = new System.Drawing.Size(696, 293);
            this.masalarlst.TabIndex = 0;
            this.masalarlst.UseCompatibleStateImageBehavior = false;
            this.masalarlst.DoubleClick += new System.EventHandler(this.masalarlst_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cafeFrms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cafeFrms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uyonetbtn;
        private System.Windows.Forms.Button yenimasaeklebtn;
        private System.Windows.Forms.ListView masalarlst;
        private System.Windows.Forms.ComboBox masalarcmb;
        private System.Windows.Forms.Timer timer1;
    }
}

