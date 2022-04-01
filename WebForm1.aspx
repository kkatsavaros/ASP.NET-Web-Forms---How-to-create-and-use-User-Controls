<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_43.User_Controls.WebForm1" %>

<%@ Register src="UserControls/CalendarUserControl.ascx" tagname="CalendarUserControl" tagprefix="uc1" %>
<%@ Register Src="~/UserControls/CalendarUserControl.ascx" TagPrefix="uc2" TagName="CalendarUserControl" %>


<!-- %@ Register Src="~/CalendarUserControl.ascx" TagPrefix="uc1" TagName="CalendarUserControl" %-->


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Date of Bitrh:
            <uc2:CalendarUserControl runat="server" ID="CalendarUserControl1" />
            
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
