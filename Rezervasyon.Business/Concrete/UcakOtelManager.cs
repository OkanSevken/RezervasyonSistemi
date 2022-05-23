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
    public class UcakOtelManager : IUcakOtelService
    {
        private IUcakOtelDal _ucakOtelDal;

        public UcakOtelManager(IUcakOtelDal ucakOtelDal)
        {
            _ucakOtelDal = ucakOtelDal;
        }
        public void Add(UcakOtel ucakOtel)
        {
            _ucakOtelDal.Add(ucakOtel);
        }

        public void Delete(UcakOtel ucakOtel)
        {
            _ucakOtelDal.Delete(ucakOtel);
        }

        public List<UcakOtel> GetAll()
        {
            return _ucakOtelDal.GetAll();
        }

        public void Update(UcakOtel ucakOtel)
        {
            _ucakOtelDal.Update(ucakOtel);
        }
    }
}
