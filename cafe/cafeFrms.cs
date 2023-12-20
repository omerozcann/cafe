using cafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class cafeFrms : Form
    {
        CafeDBEntities cde = new CafeDBEntities();
        public cafeFrms()
        {
            InitializeComponent();
        }

        public void masaGoster()
        {
            masalarlst.Clear();
            var masalar = cde.masa.Where(a => a.durum == true).ToList();
            foreach (masa masa in masalar)
            {
                ImageList il = new ImageList();
                il.ImageSize = new Size(100, 100);
                il.ColorDepth = ColorDepth.Depth24Bit;
                il.Images.Add(Image.FromFile("masa.png"));
                masalarlst.View = View.LargeIcon;
                masalarlst.LargeImageList = il;
                masalarlst.Items.Add(masa.id.ToString()+"-"+ masa.masaadi, 0);
            }           
        }
        public void masaekle(String masaAdi)
        {
            masa m = new masa();
            m.tarih=DateTime.Now;
            m.masaadi = masaAdi;
            m.durum = true;
            cde.masa.Add(m);
            cde.SaveChanges();            
            masaGoster();
        }
        private void uyonetbtn_Click(object sender, EventArgs e)
        {
            urunEkleFrm urunEkleFrm= new urunEkleFrm();
            urunEkleFrm.Show();
        }

        private void yenimasaeklebtn_Click(object sender, EventArgs e)
        {
            if(masalarcmb.SelectedIndex >= 0)
            {
                masaekle(masalarcmb.Text);
                masalarcmb.Items.RemoveAt(masalarcmb.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Masa Seçiniz");
            }
        }

        private void masalarlst_DoubleClick(object sender, EventArgs e)
        {
            if(masalarlst.SelectedItems.Count > 0) 
            {
                int masaid = int.Parse(masalarlst.Items[masalarlst.SelectedItems[0].Index].Text.Split('-')[0]);
                satisFrm sf = new satisFrm(masaid);
                sf.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            masaGoster();
        }
    }
}
