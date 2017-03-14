using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Web_Odev.Models
{
    public class OgrenciBilgi
    {
        [Key]
        public int OgrID { get; set; }
        public string OgrAdi { get; set; }
        public string OgrSoyadi { get; set; }
        public int OgrNo { get; set; }
        public int kursID { get; set; }
        //mapping
        public Kurslar kurs { get; set; }

    }
}