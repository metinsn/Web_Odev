using System;
using Web_Odev.Models;
using System.Linq;
using System.Web.UI.WebControls;
using Web_Odev.Context;

namespace Web_Odev
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (EntityBaglan database = new EntityBaglan())
            {
                Tekrar1.DataSource = database.Kurslar.ToList();
                Tekrar1.DataBind();
            }

            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (EntityBaglan database = new EntityBaglan())
                {
                    var deger = database.Kurslar.Find(id);
                    database.Kurslar.Remove(deger);
                    database.SaveChanges();
                    Response.Redirect("Kurslar.aspx");
                }
            }

            if (Request.QueryString["GID"] != null)
            {
                int gid = int.Parse(Request.QueryString["GID"]);

                using (EntityBaglan database = new EntityBaglan())
                {
                    var deger = database.Kurslar.Find(gid);
                    txtkursAdi.Text = deger.kursAdi;
                    txtkurssaati.Text = Convert.ToString(deger.kursSaati);
                    txtkursucreti.Text = Convert.ToString(deger.KursUcret);

                }
            }

        }


        protected void butonKaydet_Click(object sender, EventArgs e)
        {
            if (txtkursAdi.Text != "" && txtkurssaati.Text != "" && txtkursucreti.Text != "")
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


        protected void butonGuncelle_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["GID"] != null)
            {
                using (Context.EntityBaglan database = new Web_Odev.Context.EntityBaglan())
                {
                    int gid = int.Parse(Request.QueryString["GID"]);
                    var deger = database.Kurslar.Find(gid);
                    deger.kursAdi = txtkursAdi.Text;
                    deger.kursSaati = Convert.ToInt32(txtkurssaati.Text);
                    deger.KursUcret = Convert.ToInt32(txtkursucreti.Text);

                    database.SaveChanges();
                }
                Response.Redirect("Kurslar.aspx");
            }

        }
    }
}