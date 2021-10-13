using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfKullaniciRepository : IKullaniciDal
    {
        public List<Kullanici> Getirhepsi()
        {
            using (var context = new TodoContext())
            {
                return context.Kullanicilar.ToList();
            }
        }

        public Kullanici GetirIdile(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Kullanicilar.Find(id);
            }
        }

        public void Guncelle(Kullanici tablo)
        {
            using (var context = new TodoContext())
            {
                //Diğer yöntem sıkıntısı: tüm kolonları günceller. Gereksiz performans harcaması  
                //context.Calismalar.Update(tablo);
                context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Kaydet(Kullanici tablo)
        {
            using (var context = new TodoContext())
            {
                context.Kullanicilar.Add(tablo);
                context.SaveChanges();
            }
        }

        public void Sil(Kullanici tablo)
        {
            using (var context = new TodoContext())
            {
                context.Kullanicilar.Remove(tablo);
                context.SaveChanges();
            }
        }
    }
}
