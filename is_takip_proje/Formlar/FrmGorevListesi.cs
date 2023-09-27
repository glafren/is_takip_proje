using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }

        DbIsTakipEntities db = new DbIsTakipEntities();
        
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.Aciklama
                                       }).ToList();
            chartControl1.Series["Series 1"].Points.AddPoint("İnsan Kaynakları", 26);
            chartControl1.Series["Series 1"].Points.AddPoint("Yazılım", 34);
            chartControl1.Series["Series 1"].Points.AddPoint("Muhasebe", 33);
            chartControl1.Series["Series 1"].Points.AddPoint("Mutfak", 30);
            chartControl1.Series["Series 1"].Points.AddPoint("Temizlik", 17);
            chartControl1.Series["Series 1"].Points.AddPoint("Staj", 20);
        }
    }
}
