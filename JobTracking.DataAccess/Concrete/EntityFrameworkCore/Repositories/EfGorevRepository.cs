using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : GenericRepository<Gorev>, IGorevDal
    {
        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            using(var context= new TodoContext())
            {
                return context.Gorevler.Include(x => x.Aciliyet).Where(x => !x.Durum).OrderByDescending(x => x.OlusturulmaTarihi).ToList();
            }
        }

        public List<Gorev> GetirTumTablolarla()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler.Include(x => x.Aciliyet).Include(I=>I.Raporlar).Include(I=>I.AppUser)
                    .Where(x => !x.Durum).OrderByDescending(x => x.OlusturulmaTarihi).ToList();
            }
        }
    }
}
