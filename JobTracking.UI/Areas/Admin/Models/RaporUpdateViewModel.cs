using JobTracking.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.UI.Areas.Admin.Models
{
    public class RaporUpdateViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tanım :")]
        [Required(ErrorMessage = "Tanim Alanı Boş Geçilemez")]
        public string Tanim { get; set; }

        [Display(Name = "Detay :")]
        [Required(ErrorMessage = "Detay Alanı Boş Geçilemez")]
        public string Detay { get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
    }
}
