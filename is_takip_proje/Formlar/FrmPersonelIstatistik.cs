using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmPersonelIstatistik : Form
    {
        public FrmPersonelIstatistik()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            LblToplamFirma.Text = db.TblFirmalar.Count().ToString();
            LblToplamPersonel.Text = db.TblPersonel.Count().ToString();
            LblAktifIs.Text = db.TblGorevler.Count(x => x.Durum == "1").ToString();
            LblPasifIs.Text = db.TblGorevler.Count(x => x.Durum == "0").ToString();
            LblSonGorev.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault().ToString();
            LblSehirSayisi.Text = db.TblFirmalar.Select(x => x.İl).Distinct().Count().ToString();
            LblSektor.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            LblBugunAcilanGorevler.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();

            var pers = db.TblGorevler
                .GroupBy(x => x.GorevAlan)
                .OrderByDescending(y => y.Count())
                .Select(z => z.Key)
                .FirstOrDefault();

            var personel = db.TblPersonel.FirstOrDefault(x => x.ID == pers);
            LblAyinPersoneli.Text = personel != null ? $"{personel.Ad} {personel.Soyad}" : string.Empty;
            LblAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == personel.Departman).Select(y => y.Ad).FirstOrDefault().ToString();

            var sonGorevTarihi = db.TblGorevDetaylar
                .OrderByDescending(x => x.ID)
                .Select(x => x.Tarih)
                .FirstOrDefault();
            LblSonGorevDetay.Text = sonGorevTarihi.HasValue ? sonGorevTarihi.Value.ToString("yyyy-MM-dd") : string.Empty;

        }
    }
}
