<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style = "color:PowderBlue">2017 Event Calendar</h1>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged">
            <SelectedDayStyle BackColor="PowderBlue"></SelectedDayStyle>
            <DayStyle BackColor="#FF8080" BorderWidth="2" BorderStyle="Groove"></DayStyle>
        </asp:Calendar>
        <asp:BulletedList ID="EventList" runat="server"></asp:BulletedList>
    </div>
    </form>
</body>
</html>
