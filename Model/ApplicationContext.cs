using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2307св1.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PhoneDB.db");
            
        }
    }
}
