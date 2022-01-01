using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using JobTracking.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class TodoContext:IdentityDbContext<AppUser,AppRole,int>
    {
        //public TodoContext():base()
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=JobTracking; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent api Mapping tablosundaki işlemler Create edildi tanımlandı.  
            modelBuilder.ApplyConfiguration(new CalismaMap());
            base.OnModelCreating(modelBuilder);
        } 
        public DbSet<Gorev> Gorevler { get; set; }

        //Fluent Apiden farklı bir yöntem
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Kullanici>().HasKey(I => I.Id);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
