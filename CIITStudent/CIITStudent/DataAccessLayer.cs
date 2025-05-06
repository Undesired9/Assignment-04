using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CIITStudent
{
    public class DataAccessLayer
    {
        private readonly string constr = @"Data Source=DESKTOP-5BUNENP\SQLEXPRESS;Initial Catalog=CIITStudent;Integrated Security=True;";

        public DataSet FillDS(string query)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public void FillDD(DropDownList dd, string query)
        {
            DataSet ds = FillDS(query);
            dd.DataSource = ds.Tables[0];
            dd.DataValueField = ds.Tables[0].Columns[0].ToString();
            dd.DataTextField = ds.Tables[0].Columns[1].ToString();
            dd.DataBind();
            dd.Items.Insert(0, new ListItem("<-----Select------>", "0"));
        }
    }
}