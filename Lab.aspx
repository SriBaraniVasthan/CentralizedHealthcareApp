<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="Lab.aspx.cs" Inherits="HospitalAdministration.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Lab</h1>
     <div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" BackColor="#0099FF" BorderColor="Black" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="31px" style="margin-left: 914px" Width="90px" CausesValidation="False">Log out</asp:LinkButton>
    </div>
    <h2 style="margin-left: 360px">Request from Admin</h2>
    <div>
        <asp:GridView ID="gvrAdminReq" runat="server" AutoGenerateColumns="False" style="margin-left: 46px" Width="896px" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Height="186px" OnSelectedIndexChanged="gvrAdminReq_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Request ID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("RequestID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Doctor Name">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("DoctorName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test Name">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("TestName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Process result">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# "Lab1.aspx?Id=" + Eval("TestName") + "&ReqID=" + Server.UrlEncode(Eval("RequestID").ToString()) + "&DoctorName=" + Server.UrlEncode(Eval("DoctorName").ToString())%>'> Perform and process results</asp:LinkButton>
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
