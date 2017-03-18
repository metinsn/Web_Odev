using System;
using System.Linq;
using System.Web.UI.WebControls;
using Web_Odev.Context;
using Web_Odev.Models;

namespace Web_Odev
{
    public partial class Ogrenciler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (EntityBaglan database = new EntityBaglan())
            {
                Tekrar1.DataSource = database.OgrenciBilgi.ToList();
                Tekrar1.DataBind();
            }

            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (EntityBaglan database = new EntityBaglan())
                {
                    var deger = database.OgrenciBilgi.Find(id);
                    database.OgrenciBilgi.Remove(deger);
                    database.SaveChanges();
                    Response.Redirect("Ogrenciler.aspx");
                }
            }

            if (Request.QueryString["GID"] != null)
            {
                int gid = int.Parse(Request.QueryString["GID"]);

                using (EntityBaglan database = new EntityBaglan())
                {
                    var deger = database.OgrenciBilgi.Find(gid);
                    txtOgrAdi.Text = deger.OgrAdi;
                    txtOgrSoyAdi.Text = deger.OgrSoyadi;
                    txtOgrNo.Text = Convert.ToString(deger.OgrNo);

                }
            }

        }


        protected void butonKaydet_Click(object sender, EventArgs e)
        {
            if (txtOgrAdi.Text != "" && txtOgrSoyAdi.Text != "" && txtOgrNo.Text != "")
            {

                using (Context.EntityBaglan database = new Web_Odev.Context.EntityBaglan())
                {
                    OgrenciBilgi ogr = new OgrenciBilgi();
                    ogr.OgrSoyadi = txtOgrAdi.Text;
                    ogr.OgrSoyadi = txtOgrSoyAdi.Text;
                    ogr.OgrNo = Convert.ToInt32(txtOgrNo.Text);

                    database.OgrenciBilgi.Add(ogr);
                    database.SaveChanges();
                }
                Response.Redirect("Ogrenciler.aspx");
            }
        }


        protected void butonGuncelle_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["GID"] != null)
            {
                using (Context.EntityBaglan database = new Web_Odev.Context.EntityBaglan())
                {
                    int gid = int.Parse(Request.QueryString["GID"]);
                    var deger = database.OgrenciBilgi.Find(gid);
                    deger.OgrAdi = txtOgrAdi.Text;
                    deger.OgrSoyadi = txtOgrSoyAdi.Text;
                    deger.OgrNo = Convert.ToInt32(txtOgrNo.Text);
                
                    database.SaveChanges();
                }
                Response.Redirect("Ogrenciler.aspx");
            }

        }
    }
}