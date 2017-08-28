<%@ Page Language="C#" AutoEventWireup="true" CodeFile="create_pl.aspx.cs" Inherits="admin_create_pl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<!--#include file="inc/header.html"-->

    <div class="container">
        <h1 class="z_title">
            Admin Panel - Create Playlist
        </h1>
    </div>
    
    
    <form id="form1" runat="server" class="form-horizontal">
    <div class="container">
        <div class="form-group">
	        <label class="col-sm-2 control-label">Playlist Name</label>
	        <div class="col-sm-10">
	            <asp:TextBox ID="name_pl" runat="server" placeholder="Playlist Name" class="form-control" required></asp:TextBox>
	        </div>
        </div>
        <div class="form-group">
	        <label class="col-sm-2 control-label">Pick Songs <br />Use <i>Ctrl</i> to Select Multiple</label>
	        <div class="col-sm-10">
	            <asp:ListBox ID="ListBox1" Rows="20" SelectionMode="Multiple" class="form-control" runat="server" required></asp:ListBox>
	        </div>
        </div>
        <div class="form-group">
	        <div class="col-sm-10 col-md-offset-2">
	            <asp:Button ID="Button1" runat="server" Text="Create" class="btn btn-primary" onclick="Button1_Click" />
	        </div>
        </div>
        <br/><br/>
        <br/><br/>
    </div>
    </form>
    
<!--#include file="inc/footer.html"-->

</html>
