using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : GenericRepository<AppUser>, IAppUserDal

    {
        public List<AppUser> GetNotAdmin()
        {
            using (var context = new TodoContext());

        }
    }
}
