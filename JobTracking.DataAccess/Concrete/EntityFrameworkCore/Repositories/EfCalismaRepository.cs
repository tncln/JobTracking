using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : ICalismaDal
    {
        public List<Calisma> GetirButunCalisma()
        {
            throw new NotImplementedException();
        }

        public Calisma GetirIdCalisma(int id)
        {
            throw new NotImplementedException();
        }

        public void GuncelleCalisma(Calisma calisma)
        {
            throw new NotImplementedException();
        }

        public void KaydetCalisma(Calisma calisma)
        {
            throw new NotImplementedException();
        }

        public void SilCalisma(Calisma calisma)
        {
            throw new NotImplementedException();
        }
    }
}
