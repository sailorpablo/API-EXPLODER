using System;

public class EnviromentVariables
{
	public EnviromentVariables()
	{
		string guid = (Guid.NewGuid()).ToString();
		string nextMonth = ((DateTime.Now).AddMonths(1)).ToString("yyyy-MM-dd");

		
	}
}
