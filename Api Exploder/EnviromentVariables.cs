using System;

public class EnviromentVariables
{
    public Dictionary<string, string> variables = new Dictionary<string, string>()
    {
        { "guid", Guid.NewGuid().ToString() },
        { "nextMonth", (DateTime.Now).AddMonths(1).ToString("yyyy-MM-dd") }
    };
}

