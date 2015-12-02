<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="More.aspx.cs" Inherits="More" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">  
    
    <script
src="http://maps.googleapis.com/maps/api/js">
    </script>

    <script>
        
        var longitude = '<%= Session["longitude"] %>';
        var latitude = '<%= Session["latitude"] %>';
        var myCenter = new google.maps.LatLng(latitude, longitude);

        function initialize() {
            
            var mapProp = {
                center: myCenter,
                zoom: 9,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);

            var marker = new google.maps.Marker({
                position: myCenter,
                animation: google.maps.Animation.BOUNCE
            });

            marker.setMap(map);
        }
        
        google.maps.event.addDomListener(window, 'load', initialize);
    </script>
    <div id="MoreInfo">
        <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label><asp:Label ID="lblName" runat="server" Text=""></asp:Label><br/>
        <asp:Label ID="Label1" runat="server" Text="County: "></asp:Label><asp:Label ID="lblCouty" runat="server" Text=""></asp:Label><br/>
        <asp:Label ID="Label3" runat="server" Text="Latitude: "></asp:Label><asp:Label ID="lblLatitude" runat="server" Text=""></asp:Label><br/>
        <asp:Label ID="Label5" runat="server" Text="Longitude: "></asp:Label><asp:Label ID="lblLongitude" runat="server" Text=""></asp:Label><br/>
        <asp:Label ID="Label4" runat="server" Text="Fishes: "></asp:Label><asp:Label ID="lblFishSpec" runat="server" Text=""></asp:Label><br/>
        <asp:Label ID="Label6" runat="server" Text="SpecRegs: "></asp:Label><asp:Label ID="lblSpecRegs" runat="server" Text=""></asp:Label><br/>
        <asp:Label ID="Label7" runat="server" Text="SiteWl: "></asp:Label><asp:Label ID="lblSiteWl" runat="server" Text=""></asp:Label><br/>
        <asp:LinkButton ID="btnAdd" runat="server" Text="Add to favourites" OnClick="btnAdd_Click" />
    </div>
    <div id="googleMap"></div>
</asp:Content>