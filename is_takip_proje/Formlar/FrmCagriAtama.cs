using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
	public partial class FrmCagriAtama : Form
	{
		public FrmCagriAtama()
		{
			InitializeComponent();
		}
		DbIsTakipEntities db = new DbIsTakipEntities();
		public int id;
		private void FrmCagriAtama_Load(object sender, EventArgs e)
		{
			var personeller = (from x in db.TblPersonel
							   select new
							   {
								   x.ID,
								   AdSoyad = x.Ad + " " + x.Soyad
							   }).ToList();

			lookUpEdit1.Properties.ValueMember = "ID";
			lookUpEdit1.Properties.DisplayMember = "AdSoyad";
			lookUpEdit1.Properties.DataSource = personeller;



			TxtCagriId.Text = id.ToString();
			var deger = db.TblCagrilar.Find(id);
			TxtKonu.Text = deger.Konu;
			TxtAciklama.Text = deger.Aciklama;
			TxtTarih.Text = deger.Tarih.ToString();
			
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			var deger = db.TblCagrilar.Find(id);
			deger.Konu = TxtKonu.Text;
			deger.Tarih = Convert.ToDateTime(TxtTarih.Text);
			deger.Aciklama = TxtAciklama.Text;
			deger.CagriPersonel = int.Parse(lookUpEdit1.EditValue.ToString());
			db.SaveChanges();
			XtraMessageBox.Show("Atama İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
