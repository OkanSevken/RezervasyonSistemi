using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.Business.Abstract
{
    public interface IOtobusOtelService
    {
            List<OtobusOtel> GetAll();
            void Add(OtobusOtel otobusOtel);
            void Update(OtobusOtel otobusOtel);
            void Delete(OtobusOtel otobusOtel);
 
    }
}
