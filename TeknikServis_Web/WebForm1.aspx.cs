using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServisOtomasyon;

namespace TeknikServis_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: Bağlantı hatası alıyorum


            //var degerler = db.TBLURUNTAKIP.ToList();
            //Repeater1.DataSource = degerler;
            //Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var degerler = db.TBLURUNTAKIP.Where(x => x.SERINO == TextBox1.Text);
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}