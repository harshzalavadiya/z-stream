<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<body>
    <!--#include file="inc/header.html"-->    

    <%
        if (Session["admin_user"] != null)
        {
            Response.Redirect("panel.aspx");
        }
    %>
    
     <div class="container">
        <h1 class="z_title">Admin Panel - Login</h1>
        <div class="col-md-6 col-md-offset-3">
            <form name="logrequest" method="post" action="default.aspx" id="Form1" class="form-horizontal">
        <div>
    </div>

    <form id="logrequest" runat="server" class="form-horizontal">
        <div class="form-group">
            <label class="col-sm-2 control-label">Username</label>
            <div class="col-sm-10">
                <asp:TextBox ID="usr" runat="server" placeholder="Username" class="form-control" required></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Password</label>
            <div class="col-sm-10">
                <asp:TextBox ID="pas" runat="server" TextMode="Password" class="form-control" placeholder="Password" required></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-10 col-md-offset-2">
                <asp:Button ID="auth" runat="server" Text="Login to Admin" class="btn btn-primary" onclick="auth_Click" />
            </div>
        </div>
    </form>
    
    <!--#include file="inc/footer.html"-->
</body>
</html>