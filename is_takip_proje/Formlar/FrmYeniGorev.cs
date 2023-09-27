using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmYeniGorev : Form
    {
        public FrmYeniGorev()
        {
            InitializeComponent();
        }

        DbIsTakipEntities db = new DbIsTakipEntities();

        private void FrmYeniGorev_Load(object sender, EventArgs e)
        {
            var personeller = (from x in db.TblPersonel
                                select new
                                {
                                    x.ID,
                                   AdSoyad = x.Ad +" "+ x.Soyad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = personeller;
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblGorevler t = new TblGorevler();
            t.Aciklama = TxtAciklama.Text;
            t.Durum = true;
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.GorevVeren = int.Parse(TxtGorevVeren.Text);
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());

            db.TblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarıyle Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
