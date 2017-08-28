<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add_song.aspx.cs" Inherits="admin_add_song" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <!--#include file="inc/header.html"-->
    
    <div class="container">
        <h1 class="z_title">
            Admin Panel - Add Song #1
        </h1>
    </div>
    
    <form id="form1" class="form-horizontal" runat="server">
    <div class="container">
        <div class="form-group">
	        <label class="col-sm-2 control-label">Name of Song</label>
	        <div class="col-sm-10">
	            <asp:TextBox ID="name" runat="server" placeholder="Name" class="form-control" required></asp:TextBox>
	        </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Choose File [*.MP3]</label>
	        <div class="col-sm-10">
	            <asp:FileUpload ID="fu" runat="server" accept="audio/mp3" required />
	        </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label"></label>
	        <div class="col-sm-10">
	            <asp:Button ID="upload" runat="server" Text="Next &#8594;" class="btn btn-primary" onclick="upload_Click" />
	        </div>
        </div>
    </div>
    </form>
    
    <!--#include file="inc/footer.html"-->
</html>
