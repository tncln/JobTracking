using JobTracking.Business.Interfaces;
using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Business.Concrete
{
    public class GorevManager : IGorevService
    {
        private readonly EfGorevRepository efCalismaRepository;
        public GorevManager()
        {
            efCalismaRepository = new EfGorevRepository();
        }
        public List<Gorev> Getirhepsi()
        {
            return efCalismaRepository.Getirhepsi();
        }

        public Gorev GetirIdile(int id)
        {
            return efCalismaRepository.GetirIdile(id);
        }

        public void Guncelle(Gorev tablo)
        {
            efCalismaRepository.Guncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            efCalismaRepository.Kaydet(tablo);
        }


        public void Sil(Gorev tablo)
        {
            efCalismaRepository.Sil(tablo);
        }
    }
}
