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
    public class UcakCadırManager : IUcakCadırService
    {
        private IUcakCadırDal _ucakCadırDal;

        public UcakCadırManager(IUcakCadırDal ucakCadırDal)
        {
            _ucakCadırDal = ucakCadırDal;
        }
        public void Add(UcakCadir ucakCadır)
        {
            _ucakCadırDal.Add(ucakCadır);
        }

        public void Delete(UcakCadir ucakCadır)
        {
            _ucakCadırDal.Delete(ucakCadır);
        }

        public List<UcakCadir> GetAll()
        {
            return _ucakCadırDal.GetAll();
        }

        public void Update(UcakCadir ucakCadır)
        {
            _ucakCadırDal.Update(ucakCadır);
        }
    }
}
