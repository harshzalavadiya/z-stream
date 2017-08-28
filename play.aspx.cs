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

public partial class play : System.Web.UI.Page
{

    /*
    * <global vars>
    */

    //connection string variable
    public static String strcon = ConfigurationManager.ConnectionStrings["hash_con"].ConnectionString;
    public static SqlConnection con = new SqlConnection(strcon);
    string rawdata = null;
    public static String playdata = null;

    /*
     * </global vars>
     */


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            if (Request.QueryString["pl_id"] != null)
            {
                //Response.Write(Request.QueryString["pl_id"]);
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        else
        {
            Response.Redirect("default.aspx?z_id=au_fl");
        }



        //generates the playlist songs list


        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("select * from t_playlist where name='" + Request.QueryString["pl_id"] + "'", con);
        da.Fill(dt);

        foreach (DataRow row in dt.Rows)
        {
            rawdata = row[2].ToString();
        }

        ///--------------------------

        //Update : removes the first Comma & Last Comma added for secure song erase. - @zhnebula
        rawdata = rawdata.Remove(0, 1);
        rawdata = rawdata.Remove(rawdata.Length - 1);

        //Update : Generates the playlist script js in global var - @zhnebula
        DataTable dt1 = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter("select * from t_songs where id IN (" + rawdata.ToString() + ")", con);
        da1.Fill(dt1);
        rawdata = null;
        foreach (DataRow row1 in dt1.Rows)
        {
            rawdata += "{ image: '" + Request.Url.GetLeftPart(UriPartial.Authority) + "/music_player_new/mlib/img/" + row1[2].ToString() + "', name: '" + row1[1].ToString() + "', srcs: [ { src: '" + Request.Url.GetLeftPart(UriPartial.Authority) + "/music_player_new/mlib/song/" + row1[3].ToString() + "" + "', type: 'audio/mp3' } ] }, ";
        }






        playdata = " (function() { this.audioPlayer = new AudioPlayerUI({ el: document.getElementById('audio-player'), songs: [ "+rawdata+" ]}); }).call(this);";


        //-generates the playlist songs list
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("default.aspx?z_id=lo_su");
    }
}
