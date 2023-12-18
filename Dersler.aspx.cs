using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayerFramework;
using DataAcessLayer;
using BusinessLogicLayer;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityDers> EntDers = BLLDers.BllListele();
        List<EntityOgrenci> EntOgrenci = BLLOgrenci.BllListele();
        DropDownList1.DataSource = BLLDers.BllListele();
        DropDownList2.DataSource = BLLOgrenci.BllListele();
        DropDownList1.DataTextField = "DERSAD";
        DropDownList2.DataTextField = "Ad";
        DropDownList1.DataValueField = "DersId";
        DropDownList2.DataValueField = "Id";
        DropDownList1.DataBind();
        DropDownList2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityBasvuruForm ent = new EntityBasvuruForm();
        //ent.Basogrid = int.Parse(TextBox1.Text);
        ent.Basogrid = int.Parse(DropDownList2.SelectedValue.ToString());
        ent.Basdersid = int.Parse(DropDownList1.SelectedValue.ToString());
        BLLDers.TalepEkleBLL(ent);
    }
}