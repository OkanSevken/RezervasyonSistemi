using Rezervasyon.DataAccess.Abstract;
using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.DataAccess.Concrete.EntityFramework
{
    public class EfOtobusCadırDal:EfEntityRepositoryBase<OtobusCadir,Context>,IOtobusCadırDal
    {
    }
}
