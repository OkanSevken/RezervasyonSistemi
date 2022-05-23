using Rezervasyon.DataAccess.Abstract;
using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.DataAccess.Concrete.EntityFramework
{
    public class EfUcakOtelDal:EfEntityRepositoryBase<UcakOtel,Context>,IUcakOtelDal
    {

    }
}
