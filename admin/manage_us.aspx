﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manage_us.aspx.cs" Inherits="admin_manage_us" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<!--#include file="inc/header.html"-->

    <div class="container">
        <h1 class="z_title">
            Admin Panel - Remove Users
        </h1>
    </div>
    
    <form id="form1" runat="server">
        <div class="container">
        <table class="table table-bordered table-striped">
	        <thead>
		        <tr>
			        <th class="strong" style="width: 7%; text-align: center">#</th>
			        <th class="strong">Username</th>
			        <th class="strong" style="width: 15%;">Action</th>
		        </tr>
	        </thead>
	        <tbody>
                <%=str_ply %>
                <% str_ply = null; %>
            </tbody>
        </table>
    </div>
    </form>

<!--#include file="inc/footer.html"-->

</html>
