﻿using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : ICalismaDal
    {
        public List<Calisma> Getirhepsi()
        {
            throw new NotImplementedException();
        }

        public Calisma GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(Calisma talo)
        {
            throw new NotImplementedException();
        }

        public void Sil(Calisma tablo)
        {
            throw new NotImplementedException();
        }
    }
}
