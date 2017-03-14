using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Odev.Models
{
    public class Kurslar
    {
        [Key]
        public int kursID { get; set; }
        public string kursAdi { get; set; }
        public float KursUcret { get; set; }
        public int kursSaati { get; set; }
        //mapping
        public List<OgrenciBilgi> OgrenciBilgisi { get; set; }
    }
}