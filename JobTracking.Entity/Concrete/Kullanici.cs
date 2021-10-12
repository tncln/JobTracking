using JobTracking.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Entity.Concrete
{
    public   class Kullanici:ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }


        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public List<Calisma> Calismalar { get; set; }
    }
}
