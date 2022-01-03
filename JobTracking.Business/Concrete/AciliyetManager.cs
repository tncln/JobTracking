using JobTracking.Business.Interfaces;
using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Business.Concrete
{
    public class AciliyetManager : IAciliyetService
    {
        private readonly EfAciliyetRepository _efAciliyetRepository;
        public AciliyetManager()
        {
            _efAciliyetRepository = new EfAciliyetRepository();
        }
        public List<Aciliyet> Getirhepsi()
        {
            return _efAciliyetRepository.Getirhepsi();
        }

        public Aciliyet GetirIdile(int id)
        {
            return _efAciliyetRepository.GetirIdile(id);
        }

        public void Guncelle(Aciliyet tablo)
        {
            _efAciliyetRepository.Guncelle(tablo);
        }

        public void Kaydet(Aciliyet tablo)
        {
            _efAciliyetRepository.Kaydet(tablo);
        }

        public void Sil(Aciliyet tablo)
        {
            _efAciliyetRepository.Sil(tablo);
        }
    }
}
