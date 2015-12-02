<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="More.aspx.cs" Inherits="More" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">  
    
    <script
src="http://maps.googleapis.com/maps/api/js">
</script>

    <script>
        function initialize() {
            var longitude = '<%= Session["longitude"] %>';
            var latitude = '<%= Session["latitude"] %>';
            var mapProp = {
                center: new google.maps.LatLng(latitude, longitude),
                zoom: 9,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
        }
        
        google.maps.event.addDomListener(window, 'load', initialize);   
    </script>

    <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label><asp:Label ID="lblName" runat="server" Text=""></asp:Label><br/>
    <asp:Label ID="Label1" runat="server" Text="County: "></asp:Label><asp:Label ID="lblCouty" runat="server" Text="Label"></asp:Label><br/>
    <asp:Label ID="Label3" runat="server" Text="Latitude: "></asp:Label><asp:Label ID="lblLatitude" runat="server" Text="Label"></asp:Label><br/>
    <asp:Label ID="Label5" runat="server" Text="Longitude: "></asp:Label><asp:Label ID="lblLongitude" runat="server" Text="Label"></asp:Label><br/>
    <asp:Label ID="Label4" runat="server" Text="Fishes: "></asp:Label><asp:Label ID="lblFishSpec" runat="server" Text="Label"></asp:Label><br/>

    <div id="googleMap" style="width:500px;height:380px;"></div>
</asp:Content>