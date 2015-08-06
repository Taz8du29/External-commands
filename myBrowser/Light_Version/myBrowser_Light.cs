using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

class dummy
{[STAThread]
	public static void Main(string[] args)
	{
		//Folder Browser
		FolderBrowserDialog fo = new FolderBrowserDialog();
		fo.SelectedPath = Environment.CurrentDirectory;
		fo.ShowNewFolderButton = true;
		
		//File Browser
		OpenFileDialog fi = new OpenFileDialog();
		fi.InitialDirectory = Environment.CurrentDirectory;

		//File saver
		SaveFileDialog sv = new SaveFileDialog();
		sv.InitialDirectory = Environment.CurrentDirectory;


		for(int i = 0; i < args.Length; i++)
		{
			if(args[i] == "/fo" || args[i] == "/folder")
			{
				fo.Description = "Default description";
				if(fo.ShowDialog() == DialogResult.OK) {Console.Write(fo.SelectedPath);}
			}
			else if(args[i] == "/fi" || args[i] == "/file")
			{
				fi.Filter = "Tous les fichiers (*.*)|*.*";
				fi.ShowDialog();
				Console.Write(fi.FileName);
			}
			else if(args[i] == "/sv" || args[i] == "/save")
			{
				sv.Filter = "Tous les fichiers (*.*)|*.*";
				if(sv.ShowDialog() == DialogResult.OK && sv.FileName.Length > 0) {Console.Write(sv.FileName);}
			}
			else if(args[i] == "/h" || args[i] == "/help" || args[i] == "/?")
			{
				Console.WriteLine("Crée une boîte de dialogue pour ouvrir ou sauvegarder un fichier/un dossier.\n\n");
				Console.WriteLine("  myBrowser [/fi | /file]\n  mybrowser [/fo | /folder]\n  myBrowser [/sv | /save]");
			}
		}
	}
}