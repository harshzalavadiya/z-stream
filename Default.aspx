<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!--#include file="inc/header.html"-->
<body>
    <div class="container">
        <h1 class="z_title">Login To Z-Stream</h1>
        <div class="col-md-6 col-md-offset-3">
        <form id="logrequest" runat="server" class="form-horizontal">
	         <div class="form-group">
		        <label class="col-sm-2 control-label">Username</label>
		        <div class="col-sm-10">
		            <asp:TextBox ID="usr" class="form-control" runat="server" placeholder="Username" required></asp:TextBox>
		        </div>
	        </div>
	        <div class="form-group">
		        <label class="col-sm-2 control-label">Password</label>
		        <div class="col-sm-10">
		            <asp:TextBox ID="pas" class="form-control" runat="server" TextMode="Password" placeholder="Password" required></asp:TextBox>
		        </div>
	        </div>
	        <div class="form-group">
		        <div class="col-sm-offset-2 col-sm-5">
		            <asp:Button ID="auth" runat="server" class="btn btn-default btn-primary" onclick="Button1_Click" Text="Login" />
		        </div>
		        <div class="col-sm-5">
		            <a href="sign_up.aspx" class="btn btn-link pull-right">Create an Account !</a>
		        </div>
	        </div>            
        </form>
        </div>
    </div>
</body>
<!--#include file="inc/footer.html"-->