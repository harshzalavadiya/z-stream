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

public partial class admin_manage_pl : System.Web.UI.Page
{
    /*
   * <global vars>
   */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);
    public static String str_ply = null;

    /*
     * </global vars>
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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin_user"] == null)
        {
            Response.Redirect("Default.aspx");
        }

        try
        {
            if (Request.QueryString["delid"] != null)
            {
                con.Open();
                SqlCommand cmd_del = new SqlCommand("delete from t_playlist where id=" + Request.QueryString["delid"], con);
                cmd_del.ExecuteNonQuery();
                con.Close();

                Response.Redirect("manage_pl.aspx?z_id=pl_de");
            }
        } catch { }

        str_ply = null;

        if (Request.QueryString["z_id"] != "")
        {
            Response.Write(show_msg(Request.QueryString["z_id"]));
        }

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("select * from t_playlist", con);
        da.Fill(dt);

        foreach (DataRow row in dt.Rows)
        {
            str_ply += "<tr>";
            str_ply += "<td><center>" + row[0].ToString() + "</center></td>";
            str_ply += "<td>" + row[1].ToString() + "</td>";
            str_ply += "<td><a href='manage_pl.aspx?delid=" + row[0] + "'>Delete <i class='icon-trash'></a></td>";
            str_ply += "</tr>";
        }
    }
}
