<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HospitalAdministration.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script>
       function CustomValidator1_ClientValidate(source, args)
       {
           if (document.getElementById("<%= rdoDoctor.ClientID %>").checked || document.getElementById("<%= rdoAdmin.ClientID %>").checked || document.getElementById("<%= rdoLab.ClientID %>").checked)
           {
               args.IsValid = true;
           }
           else
           {
               args.IsValid = false;
           }

       }
   </script>
   
    <style type="text/css">
        #aligncenter {
            height: 328px;
            width: 337px;
            margin-left: 355px;
        }
        .auto-style1 {
            width: 107px;
        }
        .auto-style2 {
            width: 108px;
             
        }
        .auto-style3 {
            width: 109px;
              color: white;
    vertical-align: middle;
    text-align: center;
    font-size:large;
        }
        #radio ul li{
            display:inline-block;
        }
        
      
        
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="section">  
        <div >   
            <br />          
        <h3>Select your login  and enter the user name and password</h3>
        </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>

     <div>
       <h1 style="margin-left: 440px">Login here!</h1>
          <table  id="aligncenter" class="auto-style1" style="background-color:#0099FF">
              <tr>
                  <td class="auto-style2" colspan="2"> 
                      <div id="radio">
                          <ul>
                          <li>
                              <asp:RadioButton ID="rdoDoctor" runat="server" Text="Doctor" GroupName="Login"/>
                          </li>
                          <li>
 <asp:RadioButton ID="rdoAdmin" runat="server" Text="Admin" GroupName="Login"/>
                          </li>
                          <li>
  <asp:RadioButton ID="rdoLab" runat="server" Text="Lab" GroupName="Login"/>  
                          </li>
                      </ul> 
                      </div>
                                                                         
                                                   
                  </td>
                  <td>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please choose your designation in order to login" ClientValidationFunction="CustomValidator1_ClientValidate" OnServerValidate="CustomValidator1_ServerValidate" Display="Dynamic" ForeColor="Red">*</asp:CustomValidator>
                  </td>
              </tr>
              <tr>
                  <td class="cleft">
                    <h3> User Name:</h3> </td>
                  <td class="auto-style3">
                      <asp:TextBox ID="txtUserID" runat="server" style="margin-left: 32px" ></asp:TextBox></td>
                  <td>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fill in user name" ControlToValidate="txtUserID" ForeColor="Red">*</asp:RequiredFieldValidator>

                        </td>
              </tr>
              <tr>
                  <td class="cleft">
                     <h3>Password:</h3> 

                  </td>
                  <td class="auto-style3">
                      <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" style="margin-left: 33px" ></asp:TextBox>
                       </td>
                      
                       <td>

                    
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fill in password" ControlToValidate="txtPassword" ForeColor="Red">*</asp:RequiredFieldValidator>
                  </td>
             </tr>
              <tr>
                  <td colspan="2">
                         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                  </td>
               

              </tr>
            
              <tr>
                  <td colspan="2" class="centerBtn">
                      <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" OnClientClick="return chklogin()" Text="Login" style="margin-left: 0px;" Width="77px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="30px"   />

                  </td>
              </tr>


          </table>
    </div>

</ContentTemplate>

    </asp:UpdatePanel>
    </div>
</asp:Content>
