<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle_Bundle_Assign2_N01387542.aspx.cs" Inherits="Assignment2_N01387542_MarlMazo_5101B.Raffle_Bundle_Assign2_N01387542" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Raffle Bundle</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Ruffle Bundle Order</h1>
        <label for="orderedTickets_User">How many Tickets you want to purchase?</label>
        <asp:TextBox runat="server" id="orderedTickets_User"></asp:TextBox>
        <%-- Reference: https://stackoverflow.com/questions/1171799/text-box-validation-to-enter-value-only-more-than-zero
        Author: Henk Holterman year July 2009 --%>
        <asp:CompareValidator runat="server" 
            EnableClientScript="true" 
            ControlToValidate="orderedTickets_User"
            ErrorMessage="Please type a Valid Number"
            Operator="GreaterThan"
            Type="Integer"
            ValueToCompare="0">
        </asp:CompareValidator>
        <div>
            <asp:RequiredFieldValidator runat="server"
                ControlToValidate="orderedTickets_User"
                ErrorMessage="Please choose how many tickets."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button runat="server" Text="Submit" ID="submit"/>
        </div>
        <div runat="server" id="results_Tickets"></div>
    </form>
</body>
</html>
