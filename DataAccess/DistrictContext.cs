using Microsoft.EntityFrameworkCore;
using Parti_Secim_Anketi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti_Secim_Anketi.DataAccess
{
    public class DistrictContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Database=DistrictProject; Trusted_Connection=True");
        }

        public DbSet<District> Districts { get; set; }
    }
}
