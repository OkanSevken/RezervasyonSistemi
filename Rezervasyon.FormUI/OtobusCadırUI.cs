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
    public partial class OtobusCadırUI : Form
    {
        public OtobusCadırUI()
        {
            InitializeComponent();
            _otobusCadırService = new OtobusCadırManager(new EfOtobusCadırDal());

        }

        private IOtobusCadırService _otobusCadırService;

        public OtobusCadırUI(IOtobusCadırService otobusCadırService)
        {
            _otobusCadırService = otobusCadırService;
        }

        private void gbxRezervayonEkle_Enter(object sender, EventArgs e)
        {

        }

        private void OtobusCadır_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        private void LoadItems()
        {
            dgwGoruntule.DataSource = _otobusCadırService.GetAll();
        }
        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            _otobusCadırService.Add(new OtobusCadir
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Email = txtEmail.Text,
                KalkisNoktasi = txtNereden.Text,
                VarisNoktasi = txtNereye.Text,
                Giris = Convert.ToDateTime(dateGiris.Value.ToShortDateString()),
                Cikis=Convert.ToDateTime(dateCikis.Value.ToShortDateString()),
                BiletSayisi=Convert.ToInt32(txtBiletSayisi.Text),
                Fiyat=Convert.ToInt32(txtFiyat.Text)
            }) ;
            MessageBox.Show("Rezervasyon Basarili!!!!");
            LoadItems();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _otobusCadırService.Delete(new OtobusCadir
            {
                ID=Convert.ToInt32(dgwGoruntule.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Rezervasyon Iptali Basarili!!!!!");
            LoadItems();
        }

        
    }
}
