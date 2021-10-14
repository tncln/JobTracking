﻿using JobTracking.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobTracking.Entity.Concrete
{
    public class Calisma:ITablo
    {
  
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime AciklamaTarihi { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
