using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CodeFirseCalisma.Models
{
    public class Tedarikciler
    {
      
       
        public int ID { get; set; }
        [Display(Name = "Tedarikçi İsmi")]
        [Required(ErrorMessage = "Tedarikçi İsmi Boş Bırakılamaz")]
        [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "Tedarikçi ismi 30 Karakteri Geçemez!!")]
        public string isim { get; set; }

        [Display(Name = "Telefon Numarası")]
        [Required(ErrorMessage = "Telefon Numarası Boş Bırakılamaz")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "Telefon Numarası 11 Karakter Olmalıdır")]
        public string Telefon { get; set; }

        public virtual ICollection<Urunler> Uruns { get; set; }


    }
}