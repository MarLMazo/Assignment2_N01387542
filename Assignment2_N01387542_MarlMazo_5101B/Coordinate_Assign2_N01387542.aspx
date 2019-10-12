<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinate_Assign2_N01387542.aspx.cs" Inherits="Assignment2_N01387542_MarlMazo_5101B.Coordinate_Assignment2_N01387542" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coordinate System</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Determining Quadrants of X-Y Coordinates</h1>
        <div>
            <div>
                <label for="xValue_Number">Please Enter Number for X-coordinate</label>
                <asp:TextBox runat="server" ID="xValue_Number"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server"
                    ControlToValidate="xValue_Number"
                    ErrorMessage="Not a Valid Number"
                    ValidationExpression="[-]?[0-9]*">
                    <%-- ValidationExpression="[-]?[1-9]+[0-9]* if inputs to assume are non-zero values--%>
                </asp:RegularExpressionValidator>
                <div>
                    <asp:RequiredFieldValidator runat="server" 
                        ControlToValidate="xValue_Number"
                        ErrorMessage="Please put a number"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
            <div>
                <label for="yValue_Number">Please Enter Number for Y-coordinate</label>
                <asp:TextBox runat="server" ID="yValue_Number"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server"
                    ControlToValidate="yValue_Number"
                    ErrorMessage="Not a Valid Number"
                    ValidationExpression="[-]?[0-9]*">    
                </asp:RegularExpressionValidator>
                <div>
                    <asp:RequiredFieldValidator runat="server"
                        ControlToValidate="yValue_Number"
                        ErrorMessage="Please put a number"
                        ForeColor="Red">  
                    </asp:RequiredFieldValidator>
                </div>
            </div>
        </div> 
        <asp:Button Text="Submit" runat="server" />
        <div runat="server" id="results_Number"></div>
    </form>
</body>
</html>
