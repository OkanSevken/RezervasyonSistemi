using Rezervasyon.Business.Abstract;
using Rezervasyon.Business.Concrete;
using Rezervasyon.DataAccess.Concrete.EntityFramework;
using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon.FormUI
{
    public partial class UcakOtelUI : Form
    {
        public UcakOtelUI()
        {
            InitializeComponent();
            _ucakOtelService = new UcakOtelManager(new EfUcakOtelDal());
        }

        private IUcakOtelService _ucakOtelService;

        public UcakOtelUI(IUcakOtelService ucakOtelService)
        {
            _ucakOtelService = ucakOtelService;
        }
        private void UcakOtelUI_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        private void LoadItems()
        {
            dgwGoruntule.DataSource = _ucakOtelService.GetAll();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            _ucakOtelService.Add(new UcakOtel
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Email = txtEmail.Text,
                KalkisNoktasi = txtNereden.Text,
                VarisNoktasi = txtNereye.Text,
                Giris = Convert.ToDateTime(dateGiris.Value.ToShortDateString()),
                Cikis = Convert.ToDateTime(dateCikis.Value.ToShortDateString()),
                BiletSayisi = Convert.ToInt32(txtBiletSayisi.Text),
                Fiyat = Convert.ToInt32(txtFiyat.Text)
            });
            MessageBox.Show("Rezervasyon Basarili!!!!");
            LoadItems();
        }

        private void btnRezervasyonİptal_Click(object sender, EventArgs e)
        {
            _ucakOtelService.Delete(new UcakOtel
            {
                ID = Convert.ToInt32(dgwGoruntule.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Rezervasyon Iptali Basarili!!!!!");
            LoadItems();
        }
    }
}
