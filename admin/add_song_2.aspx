<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add_song_2.aspx.cs" Inherits="admin_add_song_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<!--#include file="inc/header.html"-->

    <div class="container">
        <h1 class="z_title">
            Admin Panel - Add Song #2
        </h1>
    </div>

    <form id="form1" runat="server" class="form-horizontal">
    <div class="container">
        <div class="form-group">
	        <label class="col-sm-2 control-label">Song Details</label>
	        <div class="col-sm-10">
	            <asp:TextBox ID="details" runat="server" class="form-control" placeholder="Details" required></asp:TextBox>
	        </div>
        </div>
        <div class="form-group">
	        <label class="col-sm-2 control-label">Upload Image [Any]</label>
	        <div class="col-sm-10">
	            <asp:FileUpload ID="iu" runat="server" accept="image/*" required />
	        </div>
        </div>
        <div class="form-group">
	        <div class="col-sm-10 col-md-offset-2">
	            <asp:Button ID="upload" runat="server" Text="Finish" class="btn btn-primary" onclick="upload_Click" />
	        </div>
        </div>        
    </div>
    </form>

<!--#include file="inc/footer.html"-->
</html>
