using Rezervasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.DataAccess.Concrete.EntityFramework
{
    public class Context:DbContext
    {
        public DbSet<OtobusCadir> OtobusCadirs { get; set; }
        public DbSet<OtobusOtel> OtobusOtels { get; set; }
        public DbSet<UcakCadir> UcakCadirs  { get; set; }
        public DbSet<UcakOtel> UcakOtels { get; set; }
    } 
}
