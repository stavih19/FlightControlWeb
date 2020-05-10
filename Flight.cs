using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FlightControlWeb
{
    public class Flight
    {
        string flight_id;
        double longitude;
        double latitude;
        int passengers;
        string company_name;
        string date_time;
        bool is_external;

        Dictionary<string, bool> dictiId = new Dictionary<string, bool>();
        Random rand = new Random();
        Mutex mut = new Mutex();

        public Flight(double longitude, double latitude, int passengers, string company_name, string date_time, bool is_external)
        {
            this.flight_id = GetFlightID();
            this.longitude = longitude;
            this.latitude = latitude;
            this.passengers = passengers;
            this.company_name = company_name;
            this.date_time = date_time;
            this.is_external = is_external;
        }

        public string Flight_id
        {
            get { return flight_id; }
        }
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }
        public string Date_time
        {
            get { return date_time; }
            set { date_time = value; }
        }
        public bool Is_external
        {
            get { return is_external; }
        }

        private string GetFlightID()
        {
            string bigLs;
            string smallLs;
            string digs;
            string newCode;
            mut.WaitOne();
            do
            {
                bigLs = GetBigLetters(rand.Next(2, 3));
                smallLs = GetSmallLetters(rand.Next(2, 3));
                digs = GetDigits(rand.Next(2, 3));

                newCode = (bigLs + smallLs + digs);
            } while (isSingleCode(newCode));

            dictiId[newCode] = true;
            mut.ReleaseMutex();
            return newCode;
        }

        private bool isSingleCode(string newCode)
        {
            foreach (KeyValuePair<string, bool> code in dictiId)
            {
                if (code.Key == newCode)
                {
                    return true;
                }
            }

            return false;
        }

        private string GetBigLetters(int n)
        {
            int codeN;
            char codeC;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                codeN = rand.Next(65, 91);
                codeC = (char)codeN;
                result += codeC;
            }
            return result;
        }

        private string GetSmallLetters(int n)
        {
            int codeN;
            char codeC;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                codeN = rand.Next(97, 123);
                codeC = (char)codeN;
                result += codeC;
            }
            return result;
        }

        private string GetDigits(int n)
        {
            int codeN;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                codeN = rand.Next(0, 10);
                result += codeN.ToString();
            }
            return result;
        }
    }
}
