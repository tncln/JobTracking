using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.DataAccess.Interfaces
{
    public interface IGorevDal:IGenericDal<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
    }
}
