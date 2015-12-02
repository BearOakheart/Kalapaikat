<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="Favourites.aspx.cs" Inherits="Favourites" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Name" InsertVisible="False" ReadOnly="True" SortExpression="Avain" />
            <asp:BoundField DataField="county" HeaderText="County" SortExpression="Rekisterinumero" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KalaConnectionString %>" SelectCommand="SELECT * FROM [Favourites]"></asp:SqlDataSource>
  
</asp:Content>

