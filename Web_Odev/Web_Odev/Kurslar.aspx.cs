using System;
using Web_Odev.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Odev.Context;

namespace Web_Odev
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {using (EntityBaglan database = new EntityBaglan())
            {
                Tekrar1.DataSource = database.Kurslar.ToList();
                Tekrar1.DataBind();
            }

        }

        protected void butonKaydet_Click(object sender, EventArgs e)
        {
            using (Context.EntityBaglan database = new Web_Odev.Context.EntityBaglan())
            {
                Kurslar kurs = new Kurslar();
                kurs.kursAdi = txtkursAdi.Text;
                kurs.kursSaati = Convert.ToInt32(txtkurssaati.Text);
                kurs.KursUcret = Convert.ToInt32(txtkursucreti.Text);

                database.Kurslar.Add(kurs);
                database.SaveChanges();
            }       
            Response.Redirect("Kurslar.aspx");
        }
    }
}