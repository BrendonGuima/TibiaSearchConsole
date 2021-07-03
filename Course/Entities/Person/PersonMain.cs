using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Person
{
    class PersonMain
    {

            public Characters characters { get; set; }
            public Information information { get; set; }

        public class Characters
        {
            public Data data { get; set; }
            public object[] achievements { get; set; }
            public Death[] deaths { get; set; }
            public Account_Information account_information { get; set; }
            public Other_Characters[] other_characters { get; set; }
        }

        public class Data
        {
            public string name { get; set; }
            public string title { get; set; }
            public string sex { get; set; }
            public string vocation { get; set; }
            public int level { get; set; }
            public int achievement_points { get; set; }
            public string world { get; set; }
            public string residence { get; set; }
            public Last_Login[] last_login { get; set; }
            public string account_status { get; set; }
            public string status { get; set; }
        }

        public class Last_Login
        {
            public string date { get; set; }
            public int timezone_type { get; set; }
            public string timezone { get; set; }
        }

        public class Account_Information
        {
            public string loyalty_title { get; set; }
            public Created created { get; set; }
        }

        public class Created
        {
            public string date { get; set; }
            public int timezone_type { get; set; }
            public string timezone { get; set; }
        }

        public class Death
        {
            public Date date { get; set; }
            public int level { get; set; }
            public string reason { get; set; }
            public Involved[] involved { get; set; }
        }

        public class Date
        {
            public string date { get; set; }
            public int timezone_type { get; set; }
            public string timezone { get; set; }
        }

        public class Involved
        {
            public string name { get; set; }
        }

        public class Other_Characters
        {
            public string name { get; set; }
            public string world { get; set; }
            public string status { get; set; }
        }

        public class Information
        {
            public int api_version { get; set; }
            public float execution_time { get; set; }
            public string last_updated { get; set; }
            public string timestamp { get; set; }
        }

    }
}
