using Microsoft.EntityFrameworkCore;
using Ogrenci_Not_Kayit_Sistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Not_Kayit_Sistemi.DataAccess
{
    public class StudentsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Database=StudentsProject; Trusted_Connection=True");
        }
        public DbSet<Students> Students { get; set; }

    }
}
