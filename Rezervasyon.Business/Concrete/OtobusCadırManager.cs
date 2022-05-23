using Rezervasyon.Business.Abstract;
using Rezervasyon.DataAccess.Abstract;
using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.Business.Concrete
{
    public class OtobusCadırManager : IOtobusCadırService
    {
        private IOtobusCadırDal _otobusCadırDal;

        public OtobusCadırManager(IOtobusCadırDal otobusCadırDal)
        {
            _otobusCadırDal = otobusCadırDal;
        }

        public void Add(OtobusCadir otobusCadır)
        {
            _otobusCadırDal.Add(otobusCadır);
        }

        public void Delete(OtobusCadir otobusCadır)
        {
            _otobusCadırDal.Delete(otobusCadır);
        }

        public List<OtobusCadir> GetAll()
        {
            return _otobusCadırDal.GetAll();
        }

        public void Update(OtobusCadir otobusCadır)
        {
            _otobusCadırDal.Update(otobusCadır);
        }
    }
}
