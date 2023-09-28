using DevExpress.Utils.Extensions;
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
	public partial class FrmCagriListesi : Form
	{
		public FrmCagriListesi()
		{
			InitializeComponent();
		}
		DbIsTakipEntities db = new DbIsTakipEntities();
		public string kullaniciAdi;
		private void FrmCagriListesi_Load(object sender, EventArgs e)
		{
			var personelId = db.TblPersonel.Where(x => x.KullaniciAdi == kullaniciAdi).Select(y => y.ID).FirstOrDefault();
			gridControl1.DataSource = (from x in db.TblCagrilar
									   select new
									   {
										   x.ID,
										   x.TblFirmalar.Ad,
										   x.TblFirmalar.Telefon,
										   x.TblFirmalar.Mail,
										   x.CagriPersonel,
										   x.Aciklama,
										   x.Durum
									   }).Where(y => y.Durum == true && y.CagriPersonel == personelId).ToList();
			gridView1.Columns["Durum"].Visible = false;
			gridView1.Columns["CagriPersonel"].Visible = false;
		}

		
		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmCagriDetayGirisi fr = new FrmCagriDetayGirisi();
			fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
			fr.Show();
		}
	}
}
