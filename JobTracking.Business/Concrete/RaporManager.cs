using JobTracking.Business.Interfaces;
using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Business.Concrete
{
    public class RaporManager : IRaporService
    {
        private readonly EfRaporRepository _raporRepository;
        public RaporManager()
        {
            _raporRepository = new EfRaporRepository();
        }
        public List<Rapor> Getirhepsi()
        {
            return _raporRepository.Getirhepsi();
                
        }

        public Rapor GetirIdile(int id)
        {
            return _raporRepository.GetirIdile(id);
        }

        public void Guncelle(Rapor tablo)
        {
            _raporRepository.Guncelle(tablo);
        }

        public void Kaydet(Rapor tablo)
        {
            _raporRepository.Kaydet(tablo);
        }

        public void Sil(Rapor tablo)
        {
            _raporRepository.Sil(tablo);
        }
    }
}
