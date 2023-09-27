using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmDepartmanlar frm;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        Formlar.FrmPersoneller frm2;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.FrmPersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        Formlar.FrmPersonelIstatistik frm3;
        private void BtnPersonelIsatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmPersonelIstatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        Formlar.FrmGorevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }

        }

        private void BtnYeniGorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniGorev frm5 = new Formlar.FrmYeniGorev();
            frm5.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay frm6 = new Formlar.FrmGorevDetay();
            frm6.Show();
        }
        Formlar.FrmAnaForm anaform;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaform == null || anaform.IsDisposed)
            {
                anaform = new Formlar.FrmAnaForm();
                anaform.MdiParent = this;
                anaform.Show();
            }
        }
		Formlar.FrmAktifCagrilar aktifcagri;
		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (aktifcagri == null || aktifcagri.IsDisposed)
			{
				aktifcagri = new Formlar.FrmAktifCagrilar();
				aktifcagri.MdiParent = this;
				aktifcagri.Show();
			}
		}
		Formlar.FrmPasifCagrilar pasifcagri;
		private void BtnPasifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (pasifcagri == null || pasifcagri.IsDisposed)
			{
				pasifcagri = new Formlar.FrmPasifCagrilar();
				pasifcagri.MdiParent = this;
				pasifcagri.Show();
			}
		}
	}
}
