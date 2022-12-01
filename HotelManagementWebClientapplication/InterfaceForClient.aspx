<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceForClient.aspx.cs" Inherits="HotelManagementWebClientapplication.InterfaceForClient" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <h1 class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Blue" Text="Room availability in Hotels" style="text-align: center; font-style: italic"></asp:Label>
        </h1>
        <div class="auto-style1">
            <asp:Label ID="Label5" runat="server" Text="You can choose rooms and contact hotels. "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Large" Font-Underline="True" Text="Debi"></asp:Label>
            <br />
            <br />
            <br />
        <br />
            <asp:Label ID="Label2" runat="server" Text="Country"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtFillByCountry" runat="server" OnTextChanged="txtFillByCountry_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFillByCountry" runat="server" OnClick="btnFillByCountry_Click" Text="Filter by Country" BackColor="Aqua" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtFillByCity" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFillByCity" runat="server" Text="Filter by City" OnClick="btnFillByCity_Click" BackColor="Aqua" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<br />
            <asp:Label ID="Label4" runat="server" Text="Hotel Name"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtFillByName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFillByName" runat="server" Text="Filter by Hotel Name" CssClass="auto-style3" OnClick="btnFillByName_Click" BackColor="Aqua" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Room's Price"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtFillByPrice" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFillByPrice" runat="server" Text="Filter by Price" OnClick="btnFillByPrice_Click" BackColor="Aqua" />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Room Type"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtFillByType" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFillByType" runat="server" Text="Filter by Room type" OnClick="btnFillByType_Click" BackColor="Aqua" />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Room Availability"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtFillByRAvailability" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFillByRAvailability" runat="server" OnClick="btnFillByRAvailability_Click" Text="Fill by Room Availability" BackColor="Aqua" />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="grd1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource2" ForeColor="Black" style="align-content:center">
                <Columns>
                    <asp:BoundField DataField="Hotel_Name" HeaderText="Hotel_Name" SortExpression="Hotel_Name" />
                    <asp:BoundField DataField="Room_Type" HeaderText="Room_Type" SortExpression="Room_Type" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="Room_Price" HeaderText="Room_Price" SortExpression="Room_Price" />
                    <asp:BoundField DataField="Room_contact_NO" HeaderText="Room_contact_NO" SortExpression="Room_contact_NO" />
                    <asp:BoundField DataField="Room_Details" HeaderText="Room_Details" SortExpression="Room_Details" />
                    <asp:BoundField DataField="Room_Availability" HeaderText="Room_Availability" SortExpression="Room_Availability" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:db_Cardiff_Test1ConnectionString %>" SelectCommand="SELECT [Hotel_Name], [Room_Type], [Country], [City], [Room_Price], [Room_contact_NO], [Room_Details], [Room_Availability] FROM [tbl_RoomManageFinal]"></asp:SqlDataSource>
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_Cardiff_Test1ConnectionString2 %>" SelectCommand="SELECT * FROM [tbl_RoomManageFinal]"></asp:SqlDataSource>
        <br />
        </div>
    
    </div>
    </form>
</body>
</html>
