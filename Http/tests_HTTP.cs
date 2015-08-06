using System;
using System.IO;
using System.Net;

class dummy
{[STAThread]*
	public static void Main(string[] args)
	{
		public string filename = null;
		public string response = null;

		for(int i = 0; i < args.Length; i++)
		{
			if(args[i] == "/o" || args[i] == "/out" || args[i] == "/output")
			{
				filename = args[i+1];
			}
			if(args[i] == "/i" || args[i] == "/in" || args[i] == "/input")
			{
				WebClient client = new WebClient();
				response = client.DownloadString(args[i+1]);
			}
		}

		

		if(filename != null)
		{
			if(!File.Exists(filename))
			{
				StreamWriter myWriter = myWriter.CreateText(filename);
				myWriter.Write(response);
				myWriter.Close();
			}
			else
			{
				Console.WriteLine("The output file already exists");
			}
		}
		else if(response != null)
		{
			Console.WriteLine(response);
		}
		else
		{
			Console.WriteLine("No URL found");
		}
	}
}