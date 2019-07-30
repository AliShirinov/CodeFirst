using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCF.Models
{
   public class PeopleDbContext : DbContext
    {
        public PeopleDbContext() : base("mydb") { }
        
        public DbSet<Person> People { get; set; }

        public DbSet<Passport> Passports { get; set; }
    }
}
