using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Guilds
{
    public class GuildsMain
    {
            public Guild guild { get; set; }
            public Information information { get; set; }


        public class Guild
        {
            public Data data { get; set; }
            public Member[] members { get; set; }
            public object[] invited { get; set; }
        }

        public class Data
        {
            public string name { get; set; }
            public string description { get; set; }
            public object[] guildhall { get; set; }
            public bool application { get; set; }
            public bool war { get; set; }
            public int online_status { get; set; }
            public int offline_status { get; set; }
            public bool disbanded { get; set; }
            public int totalmembers { get; set; }
            public int totalinvited { get; set; }
            public string world { get; set; }
            public string founded { get; set; }
            public bool active { get; set; }
            public string homepage { get; set; }
            public string guildlogo { get; set; }
        }

        public class Member
        {
            public string rank_title { get; set; }
            public Character[] characters { get; set; }
        }

        public class Character
        {
            public string name { get; set; }
            public string nick { get; set; }
            public int level { get; set; }
            public string vocation { get; set; }
            public string joined { get; set; }
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
