using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeytinYagliWebApp.Models
{
    public class Manager
    {
        public Manager()
        {
            IsActive = true;
            IsDeleted = true;
            IsAdmin = false;
        }
        public int ID { get; set; }
        [Display(Name = "Isim")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [StringLength(maximumLength: 75, ErrorMessage = "en fazla 75 karakter olmalıdır")]
        public string Name { get; set; }
        [Display(Name = "Soyisim")]
        [StringLength(maximumLength: 75, ErrorMessage = "en fazla 75 karakter olmalıdır")]
        public string Surname { get; set; }
        [Display(Name = "E-Mail")]
        [StringLength(maximumLength: 200, ErrorMessage = "en fazla 200 karakter olmalıdır")]
        public string Mail { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [StringLength(maximumLength: 20, ErrorMessage = "en fazla 20 karakter olmalıdır")]
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsAdmin { get; set; }


    }
}