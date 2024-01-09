using DLL.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DBContext
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NGOCHAI\\SQLEXPRESS;Initial Catalog=Dblab1c5;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonCompany>().ToTable("PersonCompany").HasKey(p=>p.Id);
            modelBuilder.Entity<Companies>().ToTable("Company").HasKey(p => p.Id);
            modelBuilder.Entity<People>().ToTable("People").HasKey(p => p.Id);

            modelBuilder.Entity<People>(c =>
            {
                c.Property(p => p.FirstName).HasDefaultValue("0").IsRequired();
            });

            modelBuilder.Entity<PersonCompany>().HasOne<Companies>().WithMany(c => c.LstPerson).HasForeignKey(p=>p.CompanyId);
            modelBuilder.Entity<PersonCompany>().HasOne<People>().WithMany(c => c.LstPerson).HasForeignKey(p => p.PeopleId);
        }
    }
}
