using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.IO;

namespace FlightControlWeb
{
    public class SqlDBConnection
    {
        static string flightPlanNameTable = "FlightPlanss";
        static string flightNameTable = "Flights";

        SqlConnection conn;
        SqlDataReader rdr = null;
        DataSet ds;

        public SqlDBConnection()
        {
            OpenDB();
        }

        public void OpenDB()
        {
            conn = new SqlConnection(
                "Data Source=(local);Initial Catalog=SpringfieldDB; " +
                "Integrated Security=SSPI");

            try { conn.Open(); }
            finally
            {
                if (conn != null) { conn.Close(); }
            }

            ds = new DataSet();
            DataTable flightPlans = new DataTable(flightPlanNameTable);
            DataTable flights = new DataTable(flightNameTable);
            // while run time therer will be Segment{FlightID}'s tables

            ds.Tables.Add(flightPlans);
            ds.Tables.Add(flights);
        }

        public void CloseDB()
        {
            // implement
        }

        public void InsertFlightPlan(FlightPlan flightPlan)
        {

        }
    }
}
