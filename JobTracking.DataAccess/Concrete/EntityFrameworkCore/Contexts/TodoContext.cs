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
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }
    }
}
