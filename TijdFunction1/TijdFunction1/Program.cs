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
            //varabiales
            int restTime = 500; //unit in minutes
            int walkdistance; //all distances between attractions
            int attractions = 10; //total number of attractions
           
            ////declarations of panel////

            //Route-knop//
            route = new Button();
            route.Text = "route";
            route.Size = new Size(50, 20);
            route.Location = new Point(600, 120);
            this.Controls.Add(route);
            route.Click += new EventHandler(route1_Click);
        }

        ////void methods////
        public void route1_Click(object sender, EventArgs ea)
        {
            string connectionString;
            SqlConnection connect;

            connectionString = @"Data Source=DESKTOP-Q28TMM2;Initial Catalog=Tim123;User ID=sam;Password=dat123";

            connect = new SqlConnection(connectionString);
            connect.Open();

            SqlCommand command;
            SqlDataReader reader;
            String sql,output = "";

            sql = "Select AttractionName,WaitTime from AverageQueueTime";

            command = new SqlCommand(sql, connect);

            reader = command.ExecuteReader();
            while(reader.Read())
            {
                output = output + reader.GetValue(0) + "-" + reader.GetValue(1) + "\n";
            }
            MessageBox.Show(output);

            reader.Close();
            command.Dispose();
            connect.Close();
        }

        public void Time(int waitTime, int walkdistance)
        {
            double walkTime = walkdistance/1.4;
            double estimatedTime = waitTime + walkTime;
        }
 
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
