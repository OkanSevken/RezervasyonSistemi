using Rezervasyon.Business.Abstract;
using Rezervasyon.Business.Concrete;
using Rezervasyon.DataAccess.Abstract;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _otobusCadırService = new OtobusCadırManager(new EfOtobusCadırDal());

        }
        private IOtobusCadırService _otobusCadırService;
        private IUcakCadırService _ucakCadırService;
        private IUcakOtelService _ucakOtelService;
        public Form1(IUcakOtelService ucakOtelService)
        {
            _ucakOtelService = ucakOtelService;
        }

        

        public Form1(IOtobusCadırService otobusCadırService)
        {
            _otobusCadırService = otobusCadırService;
        }

       public Form1(IUcakCadırService ucakCadırService)
        {
            _ucakCadırService = ucakCadırService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUcakCadir_Click(object sender, EventArgs e)
        {
            UcakCadırUI ucakCadır = new UcakCadırUI();
            ucakCadır.Show();
        }

        private void btnUcakOtel_Click(object sender, EventArgs e)
        {
            UcakOtelUI ucakOtel = new UcakOtelUI();
            ucakOtel.Show();
        }

        private void btnOtobusOtel_Click(object sender, EventArgs e)
        {
            OtobusOtelUI otobusOtel = new OtobusOtelUI();
            otobusOtel.Show();
        }

        private void btnOtobusCadır_Click(object sender, EventArgs e)
        {
            OtobusCadırUI otobusCadır = new OtobusCadırUI();
            otobusCadır.Show();
        }
    }
}
