using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using JobTracking.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class TodoContext:DbContext
    {
        //public TodoContext():base()
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=Todo; integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent api Mapping tablosundaki işlemler Create edildi tanımlandı. 
            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new CalismaMap());
        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }

        //Fluent Apiden farklı bir yöntem
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Kullanici>().HasKey(I => I.Id);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
