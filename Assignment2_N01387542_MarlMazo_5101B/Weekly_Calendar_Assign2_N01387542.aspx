<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weekly_Calendar_Assign2_N01387542.aspx.cs" Inherits="Assignment2_N01387542_MarlMazo_5101B.Weeky_Calendar_Assignment2_N01387542" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weekly_Calendar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Working Days</h1>
            <label for="workDay_User">What days are you working?</label>
            <asp:CheckBoxList runat="server" ID="workDay_User">
                <asp:ListItem Text="Sunday" Value="Sunday"></asp:ListItem>
                <asp:ListItem Text="Monday" Value="Monday"></asp:ListItem>
                <asp:ListItem Text="Tuesday" Value="Tuesday"></asp:ListItem>
                <asp:ListItem Text="Wednesday" Value="Wednesday"></asp:ListItem>
                <asp:ListItem Text="Thursday" Value="Thursday"></asp:ListItem>
                <asp:ListItem Text="Friday" Value="Friday"></asp:ListItem>
                <asp:ListItem Text="Saturday" Value="Saturday"></asp:ListItem>
            </asp:CheckBoxList>
            <%-- Try to Input ControlToValidate but Im getting error on this one
                Read some articles and came up that Haissam told in forum May 2007 https://forums.asp.net/t/1107775.aspx?customvalidator+not+working+for+checkbox
                That ControlToValidate is not possible in a checkbox thats why you need to remove it and only use the OnServerValidate to validate it--%>
            <asp:CustomValidator runat="server"  
                ErrorMessage="Please select your work day(s)!"
                OnServerValidate="WorkDay_User_Validate"
                ForeColor="Red">
            </asp:CustomValidator>       
        </div>
        <div> 
            <asp:Button Text="Submit" runat="server"/>
            <div runat="server" id="weekSummary_User"></div>
        </div>
    </form>
</body>
</html>
