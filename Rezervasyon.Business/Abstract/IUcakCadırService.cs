using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.Business.Abstract
{
     public interface IUcakCadırService
    {
        List<UcakCadir> GetAll();
        void Add(UcakCadir ucakCadır);
        void Update(UcakCadir ucakCadır);
        void Delete(UcakCadir ucakCadır);
    }
}
