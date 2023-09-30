using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeytinYagliWebApp.Models
{
    public class Category
    {
        public int ID { get; set; }


        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage ="Bu alan Zorunludur")]
        [StringLength(maximumLength:25,ErrorMessage ="En fazla 25 karakter olabilir")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        [StringLength(maximumLength: 250, ErrorMessage = "En fazla 250 karakter olabilir")]
        public string Description { get; set; }
        [Display(Name = "Silindi")]
        public bool IsDeleted { get; set; }
        [Display(Name = "Aktif")]
        public bool IsActive { get; set; }
    }
}