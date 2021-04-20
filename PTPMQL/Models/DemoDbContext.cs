using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        public virtual DbSet<QuanLy> QuanLys { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<test> tests { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<PTPMQL.Models.Student1> Student1 { get; set; }
    }
}
