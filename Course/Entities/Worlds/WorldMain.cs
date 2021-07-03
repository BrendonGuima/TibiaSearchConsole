
public class Rootobject
{
    public World world { get; set; }
    public Information information { get; set; }
}

public class World
{
    public World_Information world_information { get; set; }
    public Players_Online[] players_online { get; set; }
}

public class World_Information
{
    public string name { get; set; }
    public int players_online { get; set; }
    public Online_Record online_record { get; set; }
    public string creation_date { get; set; }
    public string location { get; set; }
    public string pvp_type { get; set; }
    public string[] world_quest_titles { get; set; }
    public string battleye_status { get; set; }
    public string GameWorldType { get; set; }
}

public class Online_Record
{
    public int players { get; set; }
    public Date date { get; set; }
}

public class Date
{
    public string date { get; set; }
    public int timezone_type { get; set; }
    public string timezone { get; set; }
}

public class Players_Online
{
    public string name { get; set; }
    public int level { get; set; }
    public string vocation { get; set; }
}

public class Information
{
    public int api_version { get; set; }
    public float execution_time { get; set; }
    public string last_updated { get; set; }
    public string timestamp { get; set; }
}
