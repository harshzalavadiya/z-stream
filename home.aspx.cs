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

public partial class home : System.Web.UI.Page
{
    /*
    * <global vars>
    */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);
    string rawdata = null;
    public static String listdata = null;

    /*
     * </global vars>
     */

    protected void Page_Load(object sender, EventArgs e)
    {
        listdata = null;

        if (Session["user"] != null)
        {

        }
        else
        {
            Response.Redirect("default.aspx?z_id=au_fl");
        }

        //listout all playlists
        con.Open();
        SqlCommand cmd1 = new SqlCommand("select * from t_playlist", con);
        SqlDataReader dr1 = cmd1.ExecuteReader();

        listdata += "<table class='table table-bordered table-striped'>"+
                    "<thead><tr>" +
                        "<th class='strong' style='width: 7%; text-align: center'>#</th>" + 
                        "<th class='strong'>Name</th>" + 
                        "<th class='strong'>Action</th>" +
                    "</tr><thead>";

        while (dr1.Read())
        {
            if (dr1.HasRows == true)
            {
                rawdata = dr1[1].ToString();
                listdata += "<tr>" +
                            "<td style='text-align: center'>"+ dr1[0].ToString() +"</td>" +
                            "<td>" + rawdata + "</td>" +
                            "<td style='width: 10%;'><a href='play.aspx?pl_id=" + rawdata + "'> Play <i class='icon-play'></i></a></td>" + 
                            "</tr>";
            }
        }

        listdata += "" +
                    "</table>";

        con.Close();
        //-listout all playlists
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("default.aspx?z_id=lo_su");
    }
}
