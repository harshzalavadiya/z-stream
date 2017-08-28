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

public partial class sign_up : System.Web.UI.Page
{
    /*
    * <global vars>
    */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);
    bool flag = true;

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
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        con.Open();

        SqlCommand cmde = new SqlCommand("select * from t_users where username='" + usr.Text + "'", con);
        SqlDataReader dr1 = cmde.ExecuteReader();

        while (dr1.Read())
        {
            if (dr1.HasRows == true)
            {
                flag = false;
            }
        }
        con.Close();

        if (flag == false)
        {
            Response.Redirect("sign_up.aspx?z_id=us_ex");
        }

        if (pas.Text != rep_pas.Text)
        {
            flag = false;
            Response.Redirect("sign_up.aspx?z_id=pa_nm");
        }


        //Update : Injects Data - @zhnebula
        if (flag == true)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into t_users values('" + usr.Text + "','" + pas.Text + "','1')", con);
            cmd.ExecuteNonQuery();

            con.Close();

            Response.Redirect("default.aspx?z_id=ac_su");
        }
    }
}
