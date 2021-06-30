using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Characters
    {
        public Data Data { get; set; }
        public List<object> Achievements { get; set; }
        public List<Death> Deaths { get; set; }
        public AccountInformation AccountInformation { get; set; }
        public List<OtherCharacter> OtherCharacters { get; set; }
    }
}
