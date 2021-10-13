using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : ICalismaDal
    {
        public List<Calisma> Getirhepsi()
        {
            using (var context=new TodoContext())
            {
                return context.Calismalar.ToList();
            }
        }

        public Calisma GetirIdile(int id)
        {
            using (var context = new TodoContext())
            {
                return context.Calismalar.Find(id);
            }
        }

        public void Guncelle(Calisma tablo)
        {
            using (var context = new TodoContext())
            {
                //Diğer yöntem sıkıntısı: tüm kolonları günceller. Gereksiz performans harcaması  
                //context.Calismalar.Update(tablo);
                context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Kaydet(Calisma tablo)
        {
            using (var context = new TodoContext())
            {
                context.Calismalar.Add(tablo);
                context.SaveChanges();
            }
        }

        public void Sil(Calisma tablo)
        {
            using (var context = new TodoContext())
            {
                context.Calismalar.Remove(tablo);
                context.SaveChanges();
            }
        }
    }
}
