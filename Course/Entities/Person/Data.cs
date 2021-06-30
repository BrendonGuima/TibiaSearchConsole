using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Data
    {
        public string name { get; set; }
        public string title { get; set; }
        public string sex { get; set; }
        public string vocation { get; set; }
        public int level { get; set; }
        public int achievement_points { get; set; }
        public string world { get; set; }
        public string residence { get; set; }
        public List<LastLogin> last_login { get; set; }
        public string account_status { get; set; }
        public string status { get; set; }

        public override string ToString()
        {
            return "Name: "
                + name
                + "\nTitle: "
                + title
                +"\nSex: "
                + sex;
        }
    }
}
