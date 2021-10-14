using JobTracking.Business.Interfaces;
using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly EfKullaniciRepository efKullaniciRepository;
        public KullaniciManager()
        {
            efKullaniciRepository = new EfKullaniciRepository();
        }
        public List<Kullanici> Getirhepsi()
        {
            return efKullaniciRepository.Getirhepsi();
        }

        public Kullanici GetirIdile(int id)
        {
            return efKullaniciRepository.GetirIdile(id);
        }

        public void Guncelle(Kullanici tablo)
        {
            efKullaniciRepository.Guncelle(tablo);
        }

        public void Kaydet(Kullanici tablo)
        {
            efKullaniciRepository.Kaydet(tablo);
        }

        public void Sil(Kullanici tablo)
        {
            efKullaniciRepository.Sil(tablo);
        }
    }
}
