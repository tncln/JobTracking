﻿using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Business.Interfaces
{
    public interface IGorevService:IGenericService<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
    }
}
