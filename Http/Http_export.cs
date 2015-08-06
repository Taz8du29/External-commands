using System;
using System.Net;

class dummy
{[STAThread]
	public static void Main(string[] args)
	{
		WebClient client = new WebClient();
		string response = client.DownloadString(args[0]);
		Console.WriteLine(response);
	}
}