<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Doctor.aspx.cs" Inherits="HospitalAdministration.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 39%;
        }
        .auto-style4 {
            width: 28px;
        }
        .auto-style9 {
            width: 79%;
                color: white;
    vertical-align: middle;
    text-align:center;
    font-size:large;
        }
        .auto-style10 {
            width: 162px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

<div>
      <center>
        <h2> SEND REQUEST TO LAB</h2>
         </center>
          <center>
            <table style="height: 341px; width: 346px; background-color:#0099FF; margin-left: 0px;">
                <tr>
                    <td class="auto-style9"><h3>Doctor Name:</h3></td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtdoctorname" runat="server"></asp:TextBox>    </td>
                        <td class="auto-style4">

                    
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter the Doctor name" ControlToValidate="txtdoctorname" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"><h3> Admin Name:</h3></td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtadmin" runat="server"></asp:TextBox></td>
                        <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter the Admin name" ControlToValidate="txtadmin" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"><h3>Test Name:</h3></td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="ddltestname" runat="server" Height="21px" style="margin-left: 0px" Width="76px"></asp:DropDownList>   </td>
                        <td class="auto-style4">

                     
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Test name" ControlToValidate="ddltestname" InitialValue="select" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"></asp:ValidationSummary>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="centerBtn">
                        <asp:Button ID="btnSend" runat="server" Font-Bold="True" Font-Italic="False"  OnClick="btnSend_Click" style="margin-left: 68px" Text="Send Request" Width="102px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Height="30px" />
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
            </table>
             </center>
            <br/>
           
       
    </div>

        </ContentTemplate>


    </asp:UpdatePanel>
    
   
</asp:Content>
