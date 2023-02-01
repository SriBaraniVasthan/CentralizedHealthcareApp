<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="HospitalAdministration.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
         <link href="StyleSheet1.css" rel="stylesheet" />
        .auto-style1 {
            width: 70%;
            height: 110px;
        }
        .auto-style2 {
            width: 436px;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   <div>
      <center> <h2>Notification from Doctor:</h2>

       <table class="auto-style1" style="background-color:#0099FF; height: 95px; width: 489px;">
            
           <tr>
               <td class="left" style="color:white;" >
      <asp:Label ID="lblNotify" runat="server" Text="LblNotification"></asp:Label>
               </td></tr>
            <tr><td style="color:white;"><asp:Label ID="lblTime" runat="server" Text="lblTime"></asp:Label>&nbsp;</td></tr>
           
       </table>

      </center>
       <br />
       <center> <h2>Notification from Lab:</h2>

       <table class="auto-style1" style="background-color:#0099FF;">
           <tr>
               <td class="left"  style="color:white;">
                   <h4 style="height: 35px; width: 486px">
       <asp:Label ID="lblLabNotify" runat="server" Text="LblNotification" style="margin-left: 85px" Width="278px"></asp:Label>
                   </h4>
               </td>
             
           </tr>
       </table>

      </center>
   </div>
     
    
       
</asp:Content>
