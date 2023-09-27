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

		private void FrmPersonelFormu_Load(object sender, EventArgs e)
		{

		}

		PersonelGorevFormlari.FrmAktifGorevler frm;
		private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm == null || frm.IsDisposed)
			{
				frm = new PersonelGorevFormlari.FrmAktifGorevler();
				frm.MdiParent = this;
				frm.Show();
			}
		}
	}
}
