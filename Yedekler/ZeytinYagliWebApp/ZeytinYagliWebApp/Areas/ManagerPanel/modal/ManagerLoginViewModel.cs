using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ZeytinYagliWebApp.Areas.ManagerPanel.modal
{
    public class ManagerLoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Mail alanı boş bırakılamaz")]
        public string Mail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Şifre Alanı Boş Bırakılamaz")]
        [StringLength(maximumLength:20,ErrorMessage ="Hatalı Şifre")]

        public string Password { get; set; }
    }
}