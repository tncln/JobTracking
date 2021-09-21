using JobTracking.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Entity.Concrete
{
    public class Calisma:ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklaması { get; set; }
        public DateTime AciklamaTarihi { get; set; }

        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
