using cafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class satisFrm : Form
    {
        CafeDBEntities cde = new CafeDBEntities();
        int masaid;
        public satisFrm(int id)
        {
            InitializeComponent();
            this.masaid = id;
            urunListele();
            masatxt.Text =masaid.ToString();
        }

        public void  urunListele()
        {
            var urunList = cde.urun.ToList();            
            foreach (var urun in urunList) 
            {                 
                uruncmb.Items.Add(urun.id+"-"+urun.urunadi+"-"+urun.fiyat);    
            }
            hesabiCikar();
            
        }

        public void hesabiCikar()
        {
            var satisList = cde.satis.Where(a => a.masaid == masaid).ToList();
            Double toplam = 0;
            satislst.Items.Clear();
            foreach (var satis in satisList)
            {
                var urun = cde.urun.Where(a => a.id == satis.urunid).FirstOrDefault();
                toplam = toplam + Convert.ToDouble(satis.adet * urun.fiyat);
                satislst.Items.Add(urun.urunadi + "-" + urun.fiyat+"-"+satis.adet);
            }
            satislst.Items.Add("Toplam="+toplam);
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            satis s = new satis();
            String id = uruncmb.Text.Split('-')[0];
            s.urunid = int.Parse(id);
            s.tarih = DateTime.Now;
            s.adet = int.Parse(adettxt.Text);
            s.masaid =masaid;
            cde.satis.Add(s);
            cde.SaveChanges();
            hesabiCikar();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            var masa=cde.masa.Where(a=>a.id==masaid).FirstOrDefault();
            masa.durum = false;
            cde.Entry(masa).State=System.Data.Entity.EntityState.Modified;
            cde.SaveChanges();
            this.Close();
        }
    }
}
