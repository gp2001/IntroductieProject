using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace TimeFunction1
{
    class TimeMethod : Form
    {
        //varabiales declarations//
        Button route;

        public TimeMethod()
        {
            //declarations of panel//

            //Route-knop//
            route = new Button();
            route.Text = "route";
            route.Size = new Size(50, 20);
            route.Location = new Point(600, 120);
            this.Controls.Add(route);
            route.Click += new EventHandler(route1_Click);
        }

        public void route1_Click(object sender, EventArgs ea)
        {
            string connectionString;
            SqlConnection connect;

            connectionString = @"Data Source=DESKTOP-Q28TMM2;Initial Catalog=%databasename%;User ID=ta;Password=dat123";

            connect = new SqlConnection(connectionString);
            connect.Open();
            
            connect.Close();
        }

        //void methods

        //Void method for time

        //draw event for time




    }
    class Timefunction1
    {
        static void Main()
        {
            TimeMethod screen;
            screen = new TimeMethod();
            Application.Run(screen);
        }
    }
}
