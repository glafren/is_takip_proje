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

namespace is_takip_proje.Login
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
		DbIsTakipEntities db = new DbIsTakipEntities();
		private void button1_Click(object sender, EventArgs e)
		{
			var adminvalue = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
			if (adminvalue != null)
			{
				Form1 fr = new Form1();
				fr.Show();
				this.Hide();
			}
			else
			{
				XtraMessageBox.Show("Hatalı Giriş");
				TxtKullanici.Clear();
				TxtSifre.Clear();
				TxtKullanici.Focus();
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var personel = db.TblPersonel.Where(x => x.KullaniciAdi == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
			if (personel != null)
			{
				PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
				fr.KullaniciAdi = personel.KullaniciAdi;
				fr.Show();
				this.Hide();
			}
			else
			{
				XtraMessageBox.Show("Hatalı Giriş");
				TxtKullanici.Clear();
				TxtSifre.Clear();
				TxtKullanici.Focus();
			}

			
		}

		private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
