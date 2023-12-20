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
    public partial class urunEkleFrm : Form
    {
        CafeDBEntities cde=new CafeDBEntities();
        public urunEkleFrm()
        {
            InitializeComponent();
        }

        public void listele()
        {
            var list = cde.urun.ToList();
            urunlerdgv.DataSource = list;
        }
        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            urun u = new urun();
            u.urunturu = turcmb.Text;
            u.urunadi=aditxt.Text;
            u.stokadeti =int.Parse( adettxt.Text);
            u.fiyat = decimal.Parse(fiyattxt.Text);
            u.tarih = DateTime.Now;
            cde.urun.Add(u);
            cde.SaveChanges();
            listele();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
