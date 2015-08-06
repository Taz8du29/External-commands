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
				try{fo.Description = args[i+1];}
				catch{fo.Description = "Default description";}
				if(fo.ShowDialog() == DialogResult.OK) {Console.Write(fo.SelectedPath);}
			}
			else if(args[i] == "/fi" || args[i] == "/file")
			{
				fi.Filter = Extension.ToFilter(args[i+1]);
				fi.ShowDialog();
				Console.Write(fi.FileName);
			}
			else if(args[i] == "/sv" || args[i] == "/save")
			{
				sv.Filter = Extension.ToFilter(args[i+1]);
				if(sv.ShowDialog() == DialogResult.OK && sv.FileName.Length > 0) {Console.Write(sv.FileName);}
			}
			else if(args[i] == "/h" || args[i] == "/help" || args[i] == "/?")
			{
				Console.WriteLine("Crée une boîte de dialogue pour ouvrir ou sauvegarder un fichier/un dossier.\n\n");
				Console.WriteLine("  myBrowser [/fi | /file]\n  mybrowser [/fo | /folder]\n  myBrowser [/sv | /save]");
				Console.WriteLine("\n\nUtilisation de /file et de /save :\n  myBrowser [/file | /save] \"addpreset=avi,txt; addcustom=big,Ea games files\"");
				Console.WriteLine("\naddpreset : utilise un presets (voir ci-dessous)\naddcustom : defini une extension personnalisée.\nSyntaxe : addcustom=extension,description. Utiliser un \"addcustom\" pour chacune des extensions à ajouter.\nToujours séparer les instruction par \"; \".");
				Console.WriteLine("\nLes extensions utilisées dans /save ou /file servent à filtrer les types de fichiers à afficher.");
				Console.WriteLine("\n\nUtilisation de /folder :\n  myBrowser /folder \"Insérer une description ici\"");
				Console.WriteLine("\n\nListe de tous les presets :");
				Extension.DisplayLists();
			}
		}
	}
}

class Extension
{
	//Define useful vars
	private string ext;
	private string[] exts;
	private string description;
	private string name;

	//Set commonly used file extensions
	public static Extension all = new Extension("all", "All files", "*");
	public static Extension svz = new Extension("svz", "7-Zip compressed files", "7z");
	public static Extension avi = new Extension("avi", "Avi encoded video files", "avi");
	public static Extension bat = new Extension("bat", "Batch file", "bat");
	public static Extension bin = new Extension("bin", "Binary files", "bin");
	public static Extension flv = new Extension("flv", "Flash encoded video files", "flv");
	public static Extension gif = new Extension("gif", "Gif animated image files", "gif");
	public static Extension ini = new Extension("ini", "Initialization files", "ini");
	public static Extension jar = new Extension("jar", "Java application", "jar");
	public static Extension mp3 = new Extension("mp3", "Mp3 encoded music files", "mp3");
	public static Extension pdf = new Extension("pdf", "Portable document format files", "pdf");
	public static Extension png = new Extension("png", "Png image files", "png");
	public static Extension txt = new Extension("txt", "Text files", "txt");
	public static Extension tmp = new Extension("tmp", "Temporary files", "tmp");
	public static Extension zip = new Extension("zip", "Zip compressed files", "zip");

	//Lists all the extensions
	public static Extension[] ListAll = new Extension[] {all, svz, avi, bat, bin, flv, gif, ini, jar, mp3, pdf, png, txt, tmp, zip}; //, exe, cmd, iso, img, web, code, jpg, db};


	//Create object
	public Extension(string name, string description, string ext)
	{
		this.name = name;
		this.description = description;
		this.ext = ext;
		this.exts = ext.Split(new char[] {'|'});
	}

	//Use if you need one of the object's properties
	public static string GetName(Extension inpt) {return inpt.name;}
	public static string GetDescription(Extension inpt) {return inpt.description;}
	public static string GetExtension(Extension inpt) {return inpt.ext;}

	public static string ToFilter(string ExtInput)
	{
		string Filtered = null;
		List<Extension> OutExts = new List<Extension>();
		string[] ExtSplit = ExtInput.Split(new string[] {"; "}, StringSplitOptions.None);
		
		
		for(int i = 0; i < ExtSplit.Length; i++)
		{
			string[] temp = ExtSplit[i].Split('=');
			string[] temp2 = temp[1].Split(',');

			if(temp[0] == "addpreset")
			{
				for(int j = 0; j < temp2.Length; j++)
				{
					Extension temporary = CheckExist(temp2[j]);
					if(temporary != null) {OutExts.Add(temporary);}
				}
			}
			else if(temp[0] == "addcustom") {OutExts.Add(new Extension("default", temp2[1], temp2[0]));}
		}

		for(int i = 0; i < OutExts.Count; i++)
		{
			Filtered += GetDescription(OutExts[i]) + " (*." + GetExtension(OutExts[i]) + ")|*." + GetExtension(OutExts[i]);
			if(i < OutExts.Count - 1) {Filtered += "|";}
		}

		return Filtered;
	}

	public static void DisplayLists() {for(int i = 0; i < ListAll.Length; i++) {Console.WriteLine("  " + GetName(ListAll[i]) + " : " + GetDescription(ListAll[i]) + " (*." + GetExtension(ListAll[i]) + ")");}}
	public static Extension CheckExist(string input) {for(int i = 0; i < ListAll.Length; i++) {if(input == GetName(ListAll[i])) {return ListAll[i];}} return null;}
}