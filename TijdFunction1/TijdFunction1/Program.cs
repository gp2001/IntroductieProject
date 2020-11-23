using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;
using System.Linq;

namespace TimeFunction1
{
    class TimeMethod : Form
    {
        //varabiales declarations//
        Button route;
        public int WaitTime { get; set; }
        int restTime = 500; //unit in minutes
        int walkdistance; // distance between 2 attractions
        int attractions = 10; //total number of attractions
        //public List<Elem> elements = new List<Elem> { };

        public TimeMethod()
        {  
            ////declarations of panel////

            //Route-button//
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

            String  sql, output = "";
            sql = "SELECT AttractionName, WaitTime FROM AverageQueueTime ";
            SqlCommand command = new SqlCommand(sql, connect);

            connect.Open();
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                output = output + reader.GetValue(0) + "," + reader.GetValue(1)+ ",";
                //attractionName = attractionName + reader.GetValue(0) + ",";
                //waitTime = waitTime + reader.GetValue(1) + ",";

            }

            List<string> elem = output.Split(',').ToList();
            //List<string> queuetime = waitTime.Split(',').ToList();
            //List<string> names = attractionName.Split(',').ToList();

            /*sql.ToList();*/ // converts datatable to list
            elem.ForEach(Console.WriteLine);    //shows the list in console


            reader.Close();
            command.Dispose();
            connect.Close();

        }

        public void Time(int waitTime, int walkdistance)
        {            
            double walkTime = walkdistance/1.4; //walkdistance also acquired from database
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
