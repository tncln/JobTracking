using JobTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTracking.DataAccess.Interfaces;
using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : IAppUserDal

    {
        public List<AppUser> GetNotAdmin()
        {
            //select * from AspNetUsers inner join AspNetUserRoles on AspNetUsers.Id=AspNetUserRoles.UserId
            //inner join AspNetRoles on AspNetUserRoles.RoleId=AspNetRoles.Id where AspNetRoles.Name='Member'
            using var context = new TodoContext();
            return context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) =>
            new
            {
                user = resultUser,
                userRole = resultUserRole
            }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
            {
                user=resultTable.user,
                userRoles=resultTable.userRole,
                roles=resultRole
            }).Where(I=>I.roles.Name=="Member").Select(I=>new AppUser() {
                Id=I.user.Id,
                Name=I.user.Name,
                Surname=I.user.Surname,
                Picture=I.user.Picture,
                Email=I.user.Email,
                UserName=I.user.UserName
            }).ToList();
        }

    }
    class ThreeModel
    {
        public AppUser AppUser { get; set; }
        public AppRole AppRole { get; set; }

    }
}
