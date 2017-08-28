<%@ Page Language="C#" AutoEventWireup="true" CodeFile="play.aspx.cs" Inherits="play" %>

<!--#include file="inc/header.html"-->


    <form id="form1" runat="server">
    
    
    <nav class="navbar navbar-default">
        <div class="container">
	        <div class="navbar-header">
		        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
			        <span class="sr-only">Toggle navigation</span>
			        <span class="icon-bar"></span>
			        <span class="icon-bar"></span>
			        <span class="icon-bar"></span>
		        </button>
		        <a class="navbar-brand" href="#">Z-Stream - Playing <%=Request.QueryString["pl_id"]%></a>
	        </div>

	        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
		            <ul class="nav navbar-nav navbar-right">
			            <li class="dropdown">
				            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button">Hi, <%=Session["user"] %> ! <span class="caret"></span></a>
				            <ul class="dropdown-menu" role="menu">
					            <li><asp:LinkButton ID="logout" runat="server" onclick="logout_Click">Log Out</asp:LinkButton></li>
				            </ul>
			            </li>
		            </ul>
	        </div><!-- /.navbar-collapse -->
        </div><!-- /.container-fluid -->
    </nav>
    
    
    <div>
        
        
        
        <div id="audio-player" class="audio-player-wrapper">
      <div class="audio-player-image">
        <span class="audio-player-song-name"></span>
      </div>

      <div class="audio-player-controls">
        <span class="audio-player-progress">
          <span class="audio-player-progress-bar"></span>
        </span>
        <span class="audio-player-button-wrappers">
          <a role="button" class="audio-player-button small icon-backward"></a>
          <a role="button" class="audio-player-button audio-player-place-pause-button icon-play fa-fix"></a>
          <a role="button" class="audio-player-button small icon-forward"></a>
        </span>
      </div>
    </div>
        
        
    </div>
    </form>
</body>
<!--#include file="inc/inc_js.html"-->
<% Response.Write("<script>"+playdata+"</script>"); %><!--#include file="inc/footer.html"-->