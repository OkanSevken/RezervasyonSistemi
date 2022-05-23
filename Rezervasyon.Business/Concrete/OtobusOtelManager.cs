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
    public class OtobusOtelManager : IOtobusOtelService
    {
        private IOtobusOtelDal _otobusOtelDal;

        public OtobusOtelManager(IOtobusOtelDal otobusOtelDal)
        {
            _otobusOtelDal = otobusOtelDal;
        }
        public void Add(OtobusOtel otobusOtel)
        {
            _otobusOtelDal.Add(otobusOtel);
        }

        public void Delete(OtobusOtel otobusOtel)
        {
            _otobusOtelDal.Delete(otobusOtel);
        }

        public List<OtobusOtel> GetAll()
        {
            return _otobusOtelDal.GetAll();
        }

        public void Update(OtobusOtel otobusOtel)
        {
            _otobusOtelDal.Update(otobusOtel);
        }
    }
}
