using System;
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

public partial class _Default : System.Web.UI.Page 
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




    /*-----------------------------------------------------------------------------------------*/



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



    /*-----------------------------------------------------------------------------------------*/



    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["z_id"] != "")
        {
            Response.Write(show_msg(Request.QueryString["z_id"])); 
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag_success = false;

        con.Open();

        SqlCommand cmd = new SqlCommand("select * from t_users where username='" + usr.Text + "' and pass='" + pas.Text + "'", con);

        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            if (dr.HasRows == true)
            {
                if (dr[3].ToString() == "1")
                {
                    //session user data injection
                    Session["user"] = dr[1];

                    //redirect
                    con.Close();
                    Response.Redirect("home.aspx");
                    flag_success = true;
                }
                else
                {
                    con.Close();
                    Response.Redirect("default.aspx?z_id=ac_de"); // account deactive
                }
            }
        }

        if (flag_success == false) {
            con.Close();
            Response.Redirect("default.aspx?z_id=au_fl"); // Auth Failed
        }
        
    }
}
