using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class Yazar
    {
       
            public int YazarId { get; set; }
        [Required (ErrorMessage ="Yazar Adı Soyadı Alanı Boş Geçilemez")]
        [StringLength(100, ErrorMessage ="Ad Soyad Alanı 100 Karekterden Fazla Olamaz.")]
        [Display (Name ="Yazarın Adı Soyadı")]
            public string YazarAdiSoyadi { get; set; }
        [Display(Name = "Yazarın Doğum Tarihi")]
        public DateTime YazarDogumTarihi { get; set; }
        [Required(ErrorMessage = "E posta Adresi Girmediniz")]
        [Display(Name = "Yazarın E Posta Adresi")]
        public string YazarEmailadresi { get; set; }

     
    }
}