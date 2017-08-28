<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!--#include file="inc/header.html"-->
<body>

    
    <form id="Logout" runat="server" title="Logout">
    
        <nav class="navbar navbar-default">
	        <div class="container">
		        <div class="navbar-header">
			        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
				        <span class="sr-only">Toggle navigation</span>
				        <span class="icon-bar"></span>
				        <span class="icon-bar"></span>
				        <span class="icon-bar"></span>
			        </button>
			        <a class="navbar-brand" href="#">Z-Stream</a>
		        </div>

		        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
			            <ul class="nav navbar-nav navbar-right">
				            <li class="dropdown">
					            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><% Response.Write("Hi, "+Session["user"] + " !"); %> <span class="caret"></span></a>
					            <ul class="dropdown-menu" role="menu">
						            <li><asp:LinkButton runat='server' onclick="Unnamed1_Click">Log Out</asp:LinkButton></li>
					            </ul>
				            </li>
			            </ul>
		        </div><!-- /.navbar-collapse -->
	        </div><!-- /.container-fluid -->
        </nav>

        <div class="container">
            <div class="page-header">
                <h1>Playlists <small> Click on Play Listen</small></h1>
            </div>
        
            <% Response.Write(listdata); listdata = null; %>
        </div>
    </form>
    
    <!--INC JS-->
    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.js"></script>
    <!--/INC JS-->
    
</body>
<!--#include file="inc/footer.html"-->
