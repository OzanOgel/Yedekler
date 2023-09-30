using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirseCalisma.Models
{
    public class Kategoriler
    {
       
        public int ID { get; set; }

        [Display(Name="Kategori Adı")]
        [Required(ErrorMessage ="Kategori İsmi Boş Bırakılamaz")]
        [StringLength(maximumLength:30,MinimumLength =2,ErrorMessage ="Kategori Adı 30 Karakteri Geçemez!!")]
        public string isim { get; set; }

        public virtual ICollection<Urunler> Uruns { get; set; }
    }
}