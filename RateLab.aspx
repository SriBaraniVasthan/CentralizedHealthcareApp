<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="RateLab.aspx.cs" Inherits="HospitalAdministration.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 518px;
            width: 440px;
            margin-left: 297px;
        }
       
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div><h1 style="margin-left: 465px">Lab rating</h1> </div>
    <div>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>

     <div>



        <table class="auto-style1" style="background-color:#0099FF">
            <tr>
                <td  class="cleft"><h3>Test Name:</h3></td>
                <td class="cleft">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="cleft">
               <h3>Lab Name:</h3> </td>
               
                    <td class="cleft">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td class="cleft"><h3>Rating:</h3></td>
                <td>
                    <asp:DropDownList ID="ddlRating" runat="server" Height="16px" Width="69px">
                        <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlRating" ErrorMessage="Give a Rating" ForeColor="Red" InitialValue="select">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="cleft"><h3>Comments:</h3></td>
                <td>
                    <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtComment" ErrorMessage="Give a comment for the Lab" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="cleft"><h3>Rating Date: </h3></td>
                <td>
                    <asp:TextBox ID="txtRateDate" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="18px" ImageUrl="~/Images/first.jpg" OnClick="ImageButton1_Click" style="width: 16px" />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="140px" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" ShowGridLines="True" Width="194px">
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="cleft" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td  colspan="2" class="centerBtn">
                    <asp:Button ID="btnRating" runat="server" Font-Size="Medium" OnClick="btnRating_Click" style="margin-left: 0px" Text="Submit rating" Width="126px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="30px" />
                </td>
            </tr>
        </td>
            </tr>
        </table>



    </div>


</ContentTemplate>

    </asp:UpdatePanel>
   
</asp:Content>
