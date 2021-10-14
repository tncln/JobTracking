using JobTracking.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            //Fluent Api Kullanıcı tanımları
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Ad).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Soyadi).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Telefon).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.Calismalar).WithOne(I => I.Kullanici).HasForeignKey(x => x.KullaniciId);
        }
    }
}
