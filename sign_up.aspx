<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sign_up.aspx.cs" Inherits="sign_up" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!--#include file="inc/header.html"-->
    
<div class="container">
    <h1 class="z_title">Signup To Z-Stream</h1>
    <div class="col-md-6 col-md-offset-3">
        <form id="form1" runat="server" class="form-horizontal">
            <div class="form-group">
                <label class="col-sm-2 control-label">Username</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="usr" class="form-control" runat="server" placeholder="Username" required></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Password</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="pas" class="form-control" runat="server" 
                        placeholder="Username" required TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Repeat Password</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="rep_pas" class="form-control" runat="server" 
                        placeholder="Username" required TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-4 col-md-offset-2">
                    <asp:button runat="server" class="btn btn-primary" text="Create My Account !" 
                        onclick="Unnamed1_Click" />
                </div>
                <div class="col-sm-4">
                    <a class="btn btn-link pull-right" href="Default.aspx">Back to Login</a>
                </div>
            </div>
        </form>
    </div>
</div>

<!--#include file="inc/footer.html"-->
</html>
