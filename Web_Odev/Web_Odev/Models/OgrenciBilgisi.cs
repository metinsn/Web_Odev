using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Odev.Models
{
    public class OgrenciBilgisi
    {
        public int OgrID { get; set; }
        public int OgrAdi { get; set; }
        public int OgrSoyadi { get; set; }
        public int OgrNo { get; set; }
        public int  OgrKursID { get; set; }
        public int OgrKurs { get; set; }
    }
}