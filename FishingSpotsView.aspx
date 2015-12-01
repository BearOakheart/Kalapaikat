<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="FishingSpotsView.aspx.cs" Inherits="FishingSpotsView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <asp:GridView ID="GridView1" runat="server" Height="198px" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="Name" ItemStyle-Width="150" />
                <asp:BoundField DataField="county" HeaderText="City" ItemStyle-Width="150" />
                <asp:BoundField DataField="fishSpec" HeaderText="Country" ItemStyle-Width="150" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button runat="server" Text="More" CommandArgument=""/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
     </asp:GridView>

</asp:Content>

