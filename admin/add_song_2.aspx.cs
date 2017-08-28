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

public partial class admin_add_song_2 : System.Web.UI.Page
{

    /*
   * <global vars>
   */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);
    public static String listdata = null;

    /*
     * </global vars>
     */

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin_user"] == null) {
            Response.Redirect("Default.aspx");
        }
    }
    protected void upload_Click(object sender, EventArgs e)
    {
        try
        {
            String iname_data = DateTime.Now.Ticks.ToString() + iu.FileName.ToString();
            iu.SaveAs(Server.MapPath("../mlib/img/") + iname_data);

            con.Open();
            //SqlCommand cmd = new SqlCommand("insert into t_songs values('" + name.Text.ToString() + "','" + iname_data.ToString() + "','" + fname_data.ToString() + "','" + details.Text.ToString() + "')", con);
            SqlCommand cmd = new SqlCommand("insert into t_songs values('" + Session["hash_name"].ToString() + "','" + iname_data.ToString() + "','" + Session["hash_fname_data"].ToString() + "','" + details.Text.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("panel.aspx");
        }
        catch
        {
            Response.Redirect("Default.aspx");
        }
    }
}
