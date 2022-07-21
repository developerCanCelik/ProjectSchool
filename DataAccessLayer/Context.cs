using EntitiyLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-G46VU0J; Database=KatmanDb; Trusted_Connection=true");
        }


        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
