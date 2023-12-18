using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayerFramework;
using DataAcessLayer;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
        TxtId.Text = x.ToString();
        TxtId.Enabled = false;

        if (Page.IsPostBack == false)
        {
            EntityOgrenci ent = new EntityOgrenci();
            List<EntityOgrenci> OgrDetay = BLLOgrenci.BllDetay(x);
            TxtAd.Text = OgrDetay[0].ToString();
            TxtSoyad.Text = OgrDetay[1].ToString();
            TxtNumara.Text = OgrDetay[2].ToString();
            TxtSifre.Text = OgrDetay[3].ToString();
            TxtFoto.Text = OgrDetay[4].ToString();
        }

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = TxtAd.Text;
        ent.Soyad = TxtSoyad.Text;
        ent.Numara = TxtNumara.Text;
        ent.Sifre = TxtSifre.Text;
        ent.Fotograf = TxtFoto.Text;
        ent.Id = Convert.ToInt32(TxtId.Text);
        BLLOgrenci.OgrenciGuncelleBLL(ent);
        Response.Redirect("OgrenciListesi.aspx");
    }
}