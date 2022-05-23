using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.Business.Abstract
{
    public interface IOtobusCadırService
    {
        List<OtobusCadir> GetAll();
        void Add(OtobusCadir otobusCadır);
        void Update(OtobusCadir otobusCadır);
        void Delete(OtobusCadir otobusCadır);
    }
}
