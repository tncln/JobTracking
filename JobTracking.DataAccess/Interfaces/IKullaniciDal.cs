using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Interfaces
{
    public interface IKullaniciDal
    {
        void Kaydet(Kullanici talo);
        void Sil(Kullanici tablo);
        void Guncelle(Kullanici tablo);
        Kullanici GetirIdile(int id);
        List<Kullanici> Getirhepsi();
    }
}
