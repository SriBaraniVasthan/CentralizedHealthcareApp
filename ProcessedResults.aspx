<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="ProcessedResults.aspx.cs" Inherits="HospitalAdministration.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
            <h2 style="margin-left: 400px">Results from Lab</h2>
            
         
        </div>
  <div>
<asp:GridView ID="gvrLabReq" runat="server" AutoGenerateColumns="False" CellPadding="3" style="margin-left: 45px; margin-top: 0px;" Width="944px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Height="208px" >
                <Columns>
                    <asp:TemplateField HeaderText="Request ID">
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("RequestID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Doctor Name">
                        <ItemTemplate>
                            <asp:Label ID="Label10" runat="server" Text='<%# Eval("DoctorName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Lab Name">
                        <ItemTemplate>
                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("LabName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Test Name">
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("TestName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Test results">
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("TestResults") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Results">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# "Admin3.aspx?Name=" + Eval("TestName")+ "&Results=" + Server.UrlEncode(Eval("TestResults").ToString())+ "&Labname=" + Server.UrlEncode(Eval("LabName").ToString())+ "&DocName=" + Server.UrlEncode(Eval("DoctorName").ToString())%>'>Send Lab results to Doctor</asp:LinkButton>
                       
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
  </div>
</asp:Content>
