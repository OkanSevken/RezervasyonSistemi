using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.Business.Abstract
{
     public interface IUcakOtelService
    {
        List<UcakOtel> GetAll();
        void Add(UcakOtel ucakOtel);
        void Update(UcakOtel ucakOtel);
        void Delete(UcakOtel ucakOtel);
    }
}
