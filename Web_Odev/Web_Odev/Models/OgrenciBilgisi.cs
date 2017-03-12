using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Odev.Models
{
    public class OgrenciBilgi
    {
        public int OgrID { get; set; }
        public string OgrAdi { get; set; }
        public string OgrSoyadi { get; set; }
        public int OgrNo { get; set; }
        public int  KursID { get; set; }
    }
}