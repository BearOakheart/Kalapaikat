<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="Favourites.aspx.cs" Inherits="Favourites" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <asp:GridView ID="GridView1" CssClass="mGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="FavouritesDataSource" Height="102px" Width="323px">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="spec_regs" HeaderText="spec_regs" SortExpression="spec_regs" />
            <asp:BoundField DataField="county" HeaderText="county" SortExpression="county" />
            <asp:BoundField DataField="site_wl" HeaderText="site_wl" SortExpression="site_wl" />
            <asp:BoundField DataField="point_x" HeaderText="point_x" SortExpression="point_x" />
            <asp:BoundField DataField="point_y" HeaderText="point_y" SortExpression="point_y" />
            <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnGrid" runat="server">LinkButton</asp:LinkButton>
                    </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
 
  
    <asp:SqlDataSource ID="FavouritesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:KalaConnectionString %>" SelectCommand="SELECT [Id], [name], [spec_regs], [county], [site_wl], [point_x], [point_y] FROM [Favourites] WHERE ([UserId] = @UserId)">
        <SelectParameters>
            <asp:SessionParameter Name="UserId" SessionField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
 
  
</asp:Content>

