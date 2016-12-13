<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="BMIWebAppFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>BMI (Body Mass Index) Calculator</h1>
        <p class="lead">Enter your weight and your height below. Click calculate to see your BMI.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <table style="padding: 5px; width: 100%; border: 1px solid #0000FF; background-color: #F8F8F8">
            <tr>
                <td style="width: 269px">Enter weight in pounds (lbs):</td>
                <td style="width: 401px">
            <asp:TextBox ID="txtWeight" runat="server" Width="70px" Height="30px" MaxLength="4" TextMode="Number" ToolTip="Enter weight."></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvWeightValidation" runat="server" ControlToValidate="txtWeight" ErrorMessage="Please enter valid weight."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 269px">Enter height in feet:</td>
                <td style="width: 401px">
            <asp:TextBox ID="txtHeightFeet" runat="server" Width="70px" Font-Size="Medium" Height="30px" MaxLength="1" TextMode="Number" ToolTip="Enter height (feet)."></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvFeetValidation" runat="server" ControlToValidate="txtHeightFeet" ErrorMessage="Please enter height (feet)."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 269px">Enter height in inches:</td>
                <td style="width: 401px">
            <asp:TextBox ID="txtHeightInches" runat="server" Width="70px" Font-Size="Medium" Height="30px" MaxLength="2" TextMode="Number" ToolTip="Enter height (inches)." Wrap="False"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 269px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td style="width: 401px">&nbsp;</td>
                <td>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" Width="115px" height="40px" />
                </td>
            </tr>
            <tr>
                <td style="width: 269px">
                    <asp:Label ID="lblBMIOutput" runat="server" Text="BMI: 8888" Visible="False"></asp:Label>
                </td>
                <td style="width: 401px">
                    <asp:Label ID="lblBMIStatus" runat="server" Text="BMI status is Underweight." Visible="False"></asp:Label>
                </td>
                <td>
            <asp:Button ID="btnClear" runat="server" Text="Clear" Height="40px" Width="115px" />
                </td>
            </tr>
        </table>
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
