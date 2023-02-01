<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Admin2.aspx.cs" Inherits="HospitalAdministration.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 34%;
            /*color: white;
            vertical-align: middle;
            text-align: right;
            font-size: large;*/
              color: white;
    vertical-align: middle;
    text-align: center;
    font-size:large;
             
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="section">

<asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>

  <div>
         
        <center>
           
            <table style="height: 286px; width: 369px; background-color:#0099FF;" >
                <tr>
                    <td class="auto-style1"><h3>Request ID:</h3>
                        </td>
                    <td class="cleft">
                            <asp:Label ID="lblReqID" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style1"><h3>Lab Name:</h3></td>
                        <td>
                            <asp:DropDownList ID="ddllabname" runat="server" style="margin-left: 0px" Width="86px"></asp:DropDownList>
                        </td>
                          <td>

                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select a lab" InitialValue="select" ControlToValidate="ddllabname" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <h3>Test Name:</h3></td>
                        <td>
                            <asp:TextBox ID="txttestname" runat="server" style="margin-left: 2px"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td colspan="2">
                          <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"></asp:ValidationSummary>
                    </td>
                  
                </tr>
                <tr>
                    <td colspan="2" class="centerBtn">
                          <asp:Button ID="btn_send" runat="server" Text="Send to Lab"  OnClick="btn_send_Click" style="margin-left: 0px" BackColor="White" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Height="30px"></asp:Button>

                    </td>
                  
                </tr>
            </table>
            
            <br/>
        </center>
    </div>

            </ContentTemplate>           
        </asp:UpdatePanel>
    </div>
    


   
    
</asp:Content>
