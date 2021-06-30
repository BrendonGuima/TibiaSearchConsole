using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Death
    {
        public Date Date { get; set; }
        public int Level { get; set; }
        public string Reason { get; set; }
        public List<Involved> Involved { get; set; }
    }
}
