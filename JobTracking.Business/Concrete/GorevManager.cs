using JobTracking.Business.Interfaces;
using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Business.Concrete
{
    public class GorevManager : IGorevService
    {
        private readonly IGorevDal _gorevDal;
        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal = gorevDal;
        }

        public Gorev GetirAciliyetIdile(int id)
        {
            return _gorevDal.GetirAciliyetIdile(id);
        }

        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            return _gorevDal.GetirAciliyetIleTamamlanmayan();
        }

        public List<Gorev> Getirhepsi()
        {
            return _gorevDal.Getirhepsi();
        }

        public Gorev GetirIdile(int id)
        {
            return _gorevDal.GetirIdile(id);
        }

        public List<Gorev> GetirTumTablolarla()
        {
            return _gorevDal.GetirTumTablolarla();
        }

        public void Guncelle(Gorev tablo)
        {
            _gorevDal.Guncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            _gorevDal.Kaydet(tablo);
        }


        public void Sil(Gorev tablo)
        {
            _gorevDal.Sil(tablo);
        }
    }
}
