using JobTracking.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobTracking.Entity.Concrete
{
    public class Calisma:ITablo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Ad { get; set; }
        [Column(TypeName ="ntext")]
        public string Aciklaması { get; set; }
        public DateTime AciklamaTarihi { get; set; }
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
