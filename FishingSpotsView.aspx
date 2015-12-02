<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="FishingSpotsView.aspx.cs" Inherits="FishingSpotsView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">    
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="mGrid">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="Name" ItemStyle-Width="150" />
                <asp:BoundField DataField="county" HeaderText="City" ItemStyle-Width="150" />
                <asp:BoundField DataField="fishSpec" HeaderText="Country" ItemStyle-Width="150" />
                <asp:BoundField DataField="id" HeaderText="Country" ItemStyle-Width="150" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnGrid" PostBackUrl='<%# "More.aspx?id=" + Eval("id")+"&county="+ Eval("county")+ "&longitude="+ Eval("longitude") +"&latitude="+ Eval("latitude")+"&county="+ Eval("county")%>' runat="server" Text="More"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
     </asp:GridView>
</asp:Content>

