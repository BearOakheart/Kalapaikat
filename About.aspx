<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Avain" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Avain" HeaderText="Avain" InsertVisible="False" ReadOnly="True" SortExpression="Avain" />
            <asp:BoundField DataField="Rekisterinumero" HeaderText="Rekisterinumero" SortExpression="Rekisterinumero" />
            <asp:BoundField DataField="Merkki" HeaderText="Merkki" SortExpression="Merkki" />
            <asp:BoundField DataField="Malli" HeaderText="Malli" SortExpression="Malli" />
            <asp:BoundField DataField="Vuosimalli" HeaderText="Vuosimalli" SortExpression="Vuosimalli" />
            <asp:BoundField DataField="Ajoneuvotyyppi" HeaderText="Ajoneuvotyyppi" SortExpression="Ajoneuvotyyppi" />
            <asp:BoundField DataField="Vari" HeaderText="Vari" SortExpression="Vari" />
            <asp:CheckBoxField DataField="Rekisterissa" HeaderText="Rekisterissa" SortExpression="Rekisterissa" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AjoneuvorekisteriConnectionString %>" SelectCommand="SELECT * FROM [Ajoneuvo]"></asp:SqlDataSource>
  
</asp:Content>

