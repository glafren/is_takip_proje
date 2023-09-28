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

namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmCagriDetayGirisi : Form
	{
		public FrmCagriDetayGirisi()
		{
			InitializeComponent();
		}
		DbIsTakipEntities db = new DbIsTakipEntities();
		public int id;
		private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
		{
			TxtCagriId.Text = id.ToString();
			TxtCagriId.Enabled = false;
			string saat, tarih;
			tarih = DateTime.Now.ToShortDateString();
			saat = DateTime.Now.ToShortTimeString();
			TxtTarih.Text = tarih;
			TxtSaat.Text = saat;
		}

		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			TblCagriDetay t = new TblCagriDetay();
			t.Cagri =int.Parse(TxtCagriId.Text);
			t.Saat = TxtSaat.Text;
			t.Aciklama = TxtAciklama.Text;
			t.Tarih =DateTime.Parse(TxtTarih.Text);
			db.TblCagriDetay.Add(t);
			db.SaveChanges();
			XtraMessageBox.Show("Çağrı detayı sisteme başarıyla eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			this.Close();
		}
	}
}
