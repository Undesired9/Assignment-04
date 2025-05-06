using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CIITStudent
{
    public partial class CIITStudents : System.Web.UI.Page
    {
        private readonly string constr = @"Data Source=DESKTOP-5BUNENP\SQLEXPRESS;Initial Catalog=CIITStudent;Integrated Security=True;";
        private readonly DataAccessLayer dal = new DataAccessLayer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dal.FillDD(DropDownList1, "SELECT CountrySID, CountryName FROM tblcountry");
                DropDownList2.Items.Insert(0, new ListItem("<-----Select------>", "0"));
                DropDownList3.Items.Insert(0, new ListItem("<-----Select------>", "0"));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList3.Items.Clear();
            DropDownList2.Items.Insert(0, new ListItem("<-----Select------>", "0"));
            DropDownList3.Items.Insert(0, new ListItem("<-----Select------>", "0"));

            if (DropDownList1.SelectedValue != "0")
            {
                string query = string.Format("SELECT StateSID, StateName FROM tblstate WHERE CountrySID = {0}", DropDownList1.SelectedValue);
                dal.FillDD(DropDownList2, query);
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Insert(0, new ListItem("<-----Select------>", "0"));

            if (DropDownList2.SelectedValue != "0")
            {
                string query = string.Format("SELECT CitySID, CityName FROM tblcity WHERE StateSID = {0}", DropDownList2.SelectedValue);
                dal.FillDD(DropDownList3, query);
            }
        }
    }
}