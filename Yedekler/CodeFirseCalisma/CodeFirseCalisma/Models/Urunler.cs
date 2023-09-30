using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CodeFirseCalisma.Models
{
    public class Urunler
    {
        public int ID { get; set; }

        public int KategoriID { get; set; }
        [ForeignKey("KategoriID")]
        public virtual Kategoriler Kategori { get; set; }

        public int TedarikciID { get; set; }
        [ForeignKey("TedarikciID")]
        public virtual Tedarikciler Tedarikciler { get; set; }
        [Display(Name = "Ürün İsmi")]
        [Required(ErrorMessage = "Ürün İsmi Boş Bırakılamaz")]
        [StringLength(maximumLength: 100, ErrorMessage = "Ürün İsmi 100 Karakteri Geçemez!!")]
        public string name { get; set; }

        [Display(Name = "Ürün Stoğu")]
        [Required(ErrorMessage = "Ürün Stoğu Boş Bırakılamaz")]
       
        public int stok { get; set; }

        [Display(Name = "Ürün Fiyatı")]
        [Required(ErrorMessage = "Ürün Fiyatı Boş Bırakılmaz")]
        public double Fiyat { get; set; }


    }
}