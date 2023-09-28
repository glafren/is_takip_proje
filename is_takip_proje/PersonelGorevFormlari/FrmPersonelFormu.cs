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
	public partial class FrmPersonelFormu : Form
	{
		public FrmPersonelFormu()
		{
			InitializeComponent();
		}

		public string KullaniciAdi;
		

		private void FrmPersonelFormu_Load(object sender, EventArgs e)
		{
			//this.Text = KullaniciAdi.ToString();
			this.Text = "Personel Paneli";
		}

		PersonelGorevFormlari.FrmAktifGorevler frm;
		private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm == null || frm.IsDisposed)
			{
				frm = new PersonelGorevFormlari.FrmAktifGorevler();
				frm.kullaniciAdi = KullaniciAdi;
				frm.MdiParent = this;
				frm.Show();
			}
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			PersonelGorevFormlari.FrmCagriListesi frm = new PersonelGorevFormlari.FrmCagriListesi();
			frm.kullaniciAdi=KullaniciAdi;
			frm.MdiParent = this;
			frm.Show();
		}

		PersonelGorevFormlari.FrmPasifGorevler pasifgorev;
		private void BtnPasifGorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (pasifgorev == null || pasifgorev.IsDisposed)
			{
				pasifgorev = new PersonelGorevFormlari.FrmPasifGorevler();
				pasifgorev.kullaniciAdi = KullaniciAdi;
				pasifgorev.MdiParent = this;
				pasifgorev.Show();
			}
		}
	}
}
