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
	public partial class FrmAktifGorevler : Form
	{
		public FrmAktifGorevler()
		{
			InitializeComponent();
		}

		DbIsTakipEntities db = new DbIsTakipEntities();

		private void FrmAktifGorevler_Load(object sender, EventArgs e)
		{
			var degerler = (from x in db.TblGorevler
							select new
							{
								x.ID,
								x.Aciklama,
								x.Tarih,
								x.GorevAlan,
								x.TblPersonel.Ad,
								x.Durum
							}).Where(x => x.GorevAlan == 5 && x.Durum == true).ToList();

			
			gridControl1.DataSource = degerler;
			gridView1.Columns["Durum"].Visible = false;
			gridView1.Columns["GorevAlan"].Visible = false;

		}
	}
}
