<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Admin3.aspx.cs" Inherits="HospitalAdministration.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 300px;
            width: 381px;
        }
        .auto-style2 {
            width: 268435456px;
        }
        .auto-style3 {
            width: 35%;
               color: white;
    vertical-align: middle;
    text-align: center;
    font-size:large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <center>  <h1>
        Send report to doctor
    </h1>  </center>
    </div>
   
    <div>
        <center>      
        <table class="auto-style1" style="background-color:#0099FF">
            <tr>
                <td class="auto-style3"><h3> Doctor Name: </h3></td>
                <td>
                    <asp:TextBox ID="txtDoctor" runat="server" style="margin-left: 8px; margin-top: 8px; margin-bottom: 0px;"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter the Admin name" ControlToValidate="txtDoctor" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><h3>Test Name:</h3></td>  
                <td>
                    <asp:TextBox ID="txtTestName" runat="server" style="margin-left: 0px"></asp:TextBox>
                     
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><h3>Test Results:</h3></td>
                <td>
                    <asp:TextBox ID="txtTestResults" runat="server"></asp:TextBox>
                    
                </td>
               
                
            </tr>
            <tr>
                <td colspan="2">

                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"></asp:ValidationSummary>
                </td>
            </tr>
            <tr>
                <td class="centerBtn" colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit Results to doctor" OnClick="btnSubmit_Click" style="margin-left: 0px" Width="221px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="30px" />
                </td>
            </tr>
        </table>
              </center>

    </div>
</asp:Content>
