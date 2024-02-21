using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kurs_2.Data
{
    public class MotoAppDbContext : DbContext // do DbContext dodajemy nasze zasoby 
    {
        public DbSet<Employee> Employees => Set<Employee>(); // pierwszy zasób

        public DbSet<BuisnessPartner> BuisnessPartners => Set<BuisnessPartner>(); // drugi zsób

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
