using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Odev.Models
{
    public class Kurslar
    {
        public int kursID { get; set; }
        public string kursAdi { get; set; }
        public float kursUcret { get; set; }
        public int kursSaati { get; set; }
        //mapping
        public List<OgrenciBilgi> OgrenciBilgi { get; set; }
    } 
}