using JobTracking.Business.Interfaces;
using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Business.Concrete
{
    public class CalismaManager : ICalismaService
    {
        private readonly EfCalismaRepository efCalismaRepository;
        public CalismaManager()
        {
            efCalismaRepository = new EfCalismaRepository();
        }
        public List<Calisma> Getirhepsi()
        {
            return efCalismaRepository.Getirhepsi();
        }

        public Calisma GetirIdile(int id)
        {
            return efCalismaRepository.GetirIdile(id);
        }

        public void Guncelle(Calisma tablo)
        {
            efCalismaRepository.Guncelle(tablo);
        }

        public void Kaydet(Calisma tablo)
        {
            efCalismaRepository.Kaydet(tablo);
        }

        public void Sil(Calisma tablo)
        {
            efCalismaRepository.Sil(tablo);
        }
    }
}
