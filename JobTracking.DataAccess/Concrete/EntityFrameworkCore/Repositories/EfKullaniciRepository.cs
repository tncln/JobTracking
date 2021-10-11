using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfKullaniciRepository : IKullaniciDal
    {
        public List<Kullanici> Getirhepsi()
        {
            throw new NotImplementedException();
        }

        public Kullanici GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Kullanici tablo)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(Kullanici talo)
        {
            throw new NotImplementedException();
        }

        public void Sil(Kullanici tablo)
        {
            throw new NotImplementedException();
        }
    }
}
