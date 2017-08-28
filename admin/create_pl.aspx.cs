using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class admin_create_pl : System.Web.UI.Page
{

    /*
    * <global vars>
    */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);
    bool flag_cpl = false;
    String temp_pl = null;

    /*
     * </global vars>
     */


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin_user"] == null)
        {
            Response.Redirect("Default.aspx");
        }


        if (!IsPostBack)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from t_songs", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    ListBox1.Items.Add(new ListItem(dr[1].ToString(), dr[0].ToString()));
                }
            }
            con.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected)
            {
                flag_cpl = true;
                temp_pl += item.Value.ToString() + ",";
            }
        }

        temp_pl = temp_pl.Replace(" ", string.Empty);


        if (flag_cpl == true) {
            Response.Write(temp_pl);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into t_playlist values('" + name_pl.Text + "','," + temp_pl.Trim().ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("panel.aspx");
        }
    }
}
