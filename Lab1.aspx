<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="Lab1.aspx.cs" Inherits="HospitalAdministration.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 346px;
            width: 410px;

        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>  <h2>SEND RESULTS TO ADMIN</h2></center>
     <div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" BackColor="#0099FF" BorderColor="Black" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="31px" style="margin-left: 914px" Width="90px" CausesValidation="False">Log out</asp:LinkButton>
    </div>
    <div>
<center>
      <table class="auto-style1" style="background-color:#0099FF">
            <tr>
                <td class="cleft"><h3>Request ID:</h3></td>
                <td class="cleft">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="cleft"><h3>Admin name:</h3></td>
                <td>
                    <asp:TextBox ID="txtAdminName" runat="server" style="margin-left: 2px" Width="122px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fill in ADMIN name" ControlToValidate="txtAdminName" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="cleft"><h3> Test Name:</h3></td>
                <td>
                    <asp:TextBox ID="txtTestName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="cleft"><h3>Test Results: </h3></td>
                <td>
                    <asp:TextBox ID="txtTestResults" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fill in test RESULTS" ControlToValidate="txtTestResults" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
          <tr>
              <td colspan="2">
                  <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"></asp:ValidationSummary>
              </td>
              
          </tr>
            <tr>
                <td colspan="2" class="centerBtn">
                    <asp:Button ID="btnResults" runat="server" Text="Submit results to admin" OnClick="btnResults_Click" style="margin-left: 51px" Width="167px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="30px" />
                </td>
            </tr>
        </table>
</center>
      

    </div>
</asp:Content>
