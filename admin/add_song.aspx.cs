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

public partial class admin_add_song : System.Web.UI.Page
{
    /*
    * <global vars>
    */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);
    string rawdata = null;
    public static String listdata = null;
    String fname_data = null, iname_data = null;

    /*
     * </global vars>
     */


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin_user"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void upload_Click(object sender, EventArgs e)
    {
        /*try
        {*/
            if (fu.HasFile)
            {
                fname_data = DateTime.Now.Ticks.ToString() + fu.FileName.ToString();
                fu.SaveAs(Server.MapPath("../mlib/song/") + fname_data);
                //Response.Write("<script>alert('Success')</script>");
                Session["hash_name"] = name.Text;
                Session["hash_fname_data"] = fname_data;

                Response.Redirect("add_song_2.aspx");

                /*//iname_data = DateTime.Now.Ticks.ToString() + iu.FileName.ToString();
                //iu.SaveAs(Server.MapPath("../mlib/song/") + iname_data);
                //Response.Write("<script>alert('Success')</script>");*/


            }
        /*}
        catch
        {
            Response.Redirect("Default.aspx");
        }*/
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
    }
}
