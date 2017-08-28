<%@ Page Language="C#" AutoEventWireup="true" CodeFile="panel.aspx.cs" Inherits="admin_panel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

    <!--#include file="inc/header.html"-->
    
    <form id="form1" runat="server">
    <div class="container">
        <h1 class="z_title">
            <div class="pull-right"><asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click"><i class="icon icon-power-off"></i> Logout</asp:LinkButton></div>
            Admin Panel - Choose Action
        </h1>
        <div class="btn-group btn-group-justified" role="group" aria-label="...">
          <div class="btn-group" role="group">
            <a href="add_song.aspx" class="btn btn-default">Add Song</a>
          </div>
          <div class="btn-group" role="group">
            <a href="create_pl.aspx" class="btn btn-default">Create Playlist</a>
          </div>
          <div class="btn-group" role="group">
            <a href="manage_pl.aspx" class="btn btn-default">Remove Playlist</a>
          </div>
          <div class="btn-group" role="group">
            <a href="manage_sng.aspx" class="btn btn-default">Remove Songs</a>
          </div>
          <div class="btn-group" role="group">
            <a href="manage_us.aspx" class="btn btn-default">Remove User</a>
          </div>
        </div>        
    </div>
    </form>
    
    <!--#include file="inc/footer.html"-->
