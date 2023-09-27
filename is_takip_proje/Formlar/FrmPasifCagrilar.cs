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
	public partial class FrmPasifCagrilar : Form
	{
		public FrmPasifCagrilar()
		{
			InitializeComponent();
		}
		DbIsTakipEntities db = new DbIsTakipEntities();
		private void FrmPasifCagrilar_Load(object sender, EventArgs e)
		{
			var degerler = (from x in db.TblCagrilar
							select new
							{
								x.ID,
								x.TblFirmalar.Ad,
								x.TblFirmalar.Telefon,
								x.Konu,
								x.Aciklama,
								x.Durum
							}).Where(x => x.Durum == false).ToList();
			gridControl1.DataSource = degerler;
			gridView1.Columns["Durum"].Visible = false;
		}
	}
}
