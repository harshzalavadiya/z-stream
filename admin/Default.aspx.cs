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


public partial class admin_Default : System.Web.UI.Page
{


    /*
    * <global vars>
    */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);

    /*
     * </global vars>
     */

    /*
    * <global functions>
    */

    //global message
    public static string show_msg(String z_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("select * from t_messages where d_id='" + z_id + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            if (dr.HasRows == true)
            {
                //type of error
                if (dr[2].ToString() == "e")
                {
                    z_id = "<div class='container'>" +
                           "<div class='container mtop'><div class='alert alert-danger fade in'>" +
                           "<b>Error : </b>" + dr[3].ToString() +
                           "</div></div>";
                }
                else if (dr[2].ToString() == "s")
                {
                    z_id = "<div class='container'>" +
                           "<div class='container mtop'><div class='alert alert-success fade in'>" +
                           "<b>Success : </b>" + dr[3].ToString() +
                           "</div></div>";
                }
                else
                {
                    z_id = "";
                }

                //msg from error
                //z_id += dr[3].ToString();
            }
        }

        con.Close();
        return z_id;
    }


    /*
     * </global functions>
     */



    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["z_id"] != "")
        {
            Response.Write(show_msg(Request.QueryString["z_id"]));
        }
    }
    protected void auth_Click(object sender, EventArgs e)
    {

        //migration successful
        bool flag_success = false;

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("select * from t_admins where username='" + usr.Text + "' and pass='" + pas.Text + "'", con);
        da.Fill(dt);

        foreach (DataRow row in dt.Rows)
        {
            if (row[3].ToString() == "1")
            {
                Session["admin_user"] = row[1];
                flag_success = true;
            }
        }

        if (flag_success == true)
        {
            Response.Redirect("panel.aspx");
        }
        else
        {
            Response.Redirect("default.aspx?z_id=au_fl"); // Auth Failed
        }
    }
}
