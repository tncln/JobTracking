using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Interfaces
{
    public interface ICalismaDal
    {
        void Kaydet(Calisma tablo);
        void Sil(Calisma tablo);
        void Guncelle(Calisma tablo);
        Calisma GetirIdile(int id);
        List<Calisma> Getirhepsi();
    }
}
