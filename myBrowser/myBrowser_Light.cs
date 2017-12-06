using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

class myBrwoser
{[STAThread]
	public static void Main(string[] args)
	{		
		for (int i = 0; i < args.Length; i++)
		{
			switch (args[i])
			{
				case "/d":
					//Folder Browser
					FolderBrowserDialog fo = new FolderBrowserDialog();
					fo.SelectedPath = Environment.CurrentDirectory; //curDir;
					fo.ShowNewFolderButton = true;
					if (fo.ShowDialog() == DialogResult.OK) { Console.Write(fo.SelectedPath); } else { return; }
					break;

				case "/f":
					//File Browser
					OpenFileDialog fi = new OpenFileDialog();
					fi.InitialDirectory = Environment.CurrentDirectory; //curDir;
					fi.Filter = "All files (*.*)|*.*";
					fi.ShowDialog();
					Console.Write(fi.FileName);
					break;

				case "/o":
					//File saver
					SaveFileDialog sv = new SaveFileDialog();
					sv.InitialDirectory = Environment.CurrentDirectory; //curDir;
					sv.Filter = "All files (*.*)|*.*";
					if (sv.ShowDialog() == DialogResult.OK) { Console.Write(sv.FileName); } else { return; }
					break;
			
				default: 
					Console.WriteLine("Opens file/folder browsing UI.\n\n");
					Console.WriteLine("  myBrowser [/f]    opens file\n  mybrowser [/d]    opens folder\n  myBrowser [/o]    saves file");
					break;
			}
		}
	}
}