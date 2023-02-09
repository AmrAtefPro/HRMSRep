using HRMS.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DBContext
{
    public class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DataBaseContext()
        {
        }
        public DataBaseContext(DbContextOptions _options) //: base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=HRMSDB;Integrated Security=True");
        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        //public virtual DbSet<StudentSubject> StudentSubject { get; set; }


    }
}
