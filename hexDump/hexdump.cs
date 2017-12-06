using System;
using System.IO;
using System.Diagnostics;

/**
* Application for printing file to console as hexadecimal.
*/
class HexDump
{ [STAThread]
	protected static void Main(String[] args)
	{
		string path = "";

		if (args.Length != 2) { printUsage(); return; }
		else
		{
			switch (args[0])
			{
				case "/h": path = args[1]; break;
				default: printUsage(); return;
			}
		}

		if (!File.Exists(path)) { Console.WriteLine("{0} : Can't open file (Reason: file not found)", path); }
		//else if (FileInfo.Length(path) > 1048575) { Console.WriteLine("{0} : Can't open file (Reason: file is over 1 MiB (1049 kB))", path); }
		else
		{ 
			try
			{
				using (FileStream fs = File.OpenRead(path))
				{
					Stopwatch timer = new Stopwatch();
					timer.Start();
					
					int fileSize = formatOutput(fs, 16);
					
					timer.Stop();

					Console.WriteLine();
					Console.WriteLine("Dump Done");
					Console.WriteLine("Parsed " + fileSize + " bytes in " + timer.ElapsedMilliseconds + "ms");
					Console.WriteLine();
 				}
 			}
			catch (Exception e) { Console.WriteLine(e); }
		}
		
		return;
	}
	
	public static void printUsage()
	{
		Console.WriteLine("usage: hexdump.exe /h <filename>");
		Console.WriteLine("    /h  hex dump (16 bits per line");
	}

	
	public static int formatOutput(FileStream file, int lineSize)
	{
		byte[] buffer = new byte[lineSize];
		int address = 0;
		int buffered = 1;
		
		while (buffered > 0)
		{
			buffered = file.Read(buffer, 0, lineSize);
			if (buffered == 0) { break; }

			Console.Write("[" + wordToHex(address, 24) + "]  ");
			
			for (int i = 0; i < buffered; i++) { Console.Write(wordToHex(buffer[i], 8) + " "); }			
			if (buffered < lineSize) { for (int i = buffered; i < lineSize; i++) { Console.Write("   "); }}
			
			Console.Write(" ");
			for (int i = 0; i < buffered; i++) { Console.Write(hexToAscii(buffer[i])); }
			
			Console.WriteLine();
			address += buffered;
		}

		return address;
	}


	/*
	 * Converts a byte to string (e.g. 0x01011110 -> "5E")
	*/
	public static string wordToHex(int b, int size)
	{
		string[] hexChar = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"}; 
		string output = "";

		for (int i = size-4; i >= 0; i -= 4)
		{
			char nibble = (char) ((b>>i) & 0xF);
			output += hexChar[nibble];
		}

		return output;
	}
	
	/*
	 * Converts the byte to a visible ASCII character or dot if it is not.
	*/
	public static char hexToAscii(uint b)
	{
		if (b >= 32 && b <= 126) { return (char) b; }
		return '.';
	}

}
