using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Entity.Concrete;

namespace UcundanTut.DataAccess.Concrete
{
    public class UcundanTutContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=UcundanTut;Trusted_Connection=True;");
        }

        public DbSet<Dernek> Dernekler { get; set; }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
    }
}
