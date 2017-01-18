using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] events = new string[6, 2];

    protected void Page_Load(object sender, EventArgs e)
    {
        events[0, 0] = "Oil Change";
        events[0, 1] = "1/10/2017";
        events[1, 0] = "Dentist Appointment";
        events[1, 1] = "1/25/2017";
        events[2, 0] = "Dinner Plans with Steve";
        events[2, 1] = "1/17/2017";
        events[3, 0] = "Calendar Project Due";
        events[3, 1] = "1/18/2017";
        events[4, 0] = "Temperature Conversion Project Due";
        events[4, 1] = "1/17/2017";
        events[5, 0] = "Wine Tasting";
        events[5, 1] = "1/31/2017";
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        EventList.Items.Clear();
        GetEvents();
    }
    protected void GetEvents()
    {
            if (Calendar1.SelectedDate == DateTime.Parse(events[0, 1]))
            {
                EventList.Items.Add(events[0, 0]);
                EventList.ForeColor = System.Drawing.Color.Green;
            }
            if (Calendar1.SelectedDate == DateTime.Parse(events[1, 1]))
            {
                EventList.Items.Add(events[1, 0]);
                EventList.ForeColor = System.Drawing.Color.Red;
            }
            if (Calendar1.SelectedDate == DateTime.Parse(events[2, 1]))
            {
                EventList.Items.Add(events[2, 0]);
                EventList.ForeColor = System.Drawing.Color.Pink;
            }
            if (Calendar1.SelectedDate == DateTime.Parse(events[3, 1]))
            {
                EventList.Items.Add(events[3, 0]);
                EventList.ForeColor = System.Drawing.Color.Purple;
            }
            if (Calendar1.SelectedDate == DateTime.Parse(events[4, 1]))
            {
                EventList.Items.Add(events[4, 0]);
            }
            if (Calendar1.SelectedDate == DateTime.Parse(events[5, 1]))
            {
                EventList.Items.Add(events[5, 0]);
                EventList.ForeColor = System.Drawing.Color.Turquoise;
            }
            if (EventList.Items.Count == 0)
            {
                EventList.Items.Add("No events for today.");
                EventList.ForeColor = System.Drawing.Color.PowderBlue;
            }
    }
}