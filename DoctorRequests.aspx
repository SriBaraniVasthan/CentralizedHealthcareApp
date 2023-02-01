<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="DoctorRequests.aspx.cs" Inherits="HospitalAdministration.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2 style="margin-left: 401px">Request to Lab</h2>
        <asp:GridView ID="gvrReqLab" runat="server" AutoGenerateColumns="False" style="margin-right: 45px; margin-left: 25px;" Width="939px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3"   >
             <Columns>
                 <asp:TemplateField HeaderText="Request ID">
                     <ItemTemplate>
                         <asp:Label ID="Label7" runat="server" Text='<%# Eval("RequestID") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Doctor NAME">
                   
                     <ItemTemplate>
                         <asp:Label ID="Label3" runat="server" Text='<%# Eval("DoctorName") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Test Name">
                     
                     <ItemTemplate>
                         <asp:Label ID="Label4" runat="server" Text='<%# Eval("TestName") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
               
                 <asp:TemplateField HeaderText="Request">
                     <ItemTemplate>
                         <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# "Admin2.aspx?Id=" + Eval("TestName") + "&ReqID=" + Server.UrlEncode(Eval("RequestID").ToString())  + "&DocName=" + Server.UrlEncode(Eval("DoctorName").ToString())%>'>Process request</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>
               
             </Columns>
             <FooterStyle BackColor="White" ForeColor="#000066" />
             <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
             <RowStyle ForeColor="#000066" />
             <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#F1F1F1" />
             <SortedAscendingHeaderStyle BackColor="#007DBB" />
             <SortedDescendingCellStyle BackColor="#CAC9C9" />
             <SortedDescendingHeaderStyle BackColor="#00547E" />
         </asp:GridView>
        <br />
</asp:Content>
