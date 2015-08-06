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


		//test
		Form fm = new Form();
		fm.Size = new Size(280, 200);
		fm.MaximumSize = fm.MinimumSize = fm.Size;
		fm.Text = "Bonjour";
		fm.BackColor = Color.Blue;

		TextBox txt = new TextBox();
		txt.Size = new Size(210, 50);
		txt.Location = new Point(25, 25);
		txt.Text = "ceci est un test !";
		txt.Multiline = true;
		fm.Controls.Add(txt);

		Button cancel = new Button();
		cancel.Size = new Size(75,25);
		cancel.Location = new Point(txt.Left + 25, txt.Bottom + 15);
		cancel.FlatStyle = FlatStyle.System;
		cancel.Text = "Cancel";

		Button ok = new Button();
		ok.FlatStyle = FlatStyle.System;
		ok.Top = cancel.Top;
		ok.Left = cancel.Right + 10;
		ok.Width = cancel.Width;
		ok.Height = cancel.Height;
		ok.Text = "Ok";

		fm.AcceptButton = ok;
		fm.CancelButton = cancel;
		fm.Controls.AddRange(new Control[] {ok, cancel} );





		for(int i = 0; i < args.Length; i++)
		{
			if(args[i] == "/fo" || args[i] == "/folder")
			{
				fo.Description = args[i+1];
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
				try {sv.Filter = args[i+1];}
				catch {sv.Filter = "Text files (*.txt)|*.txt|All files|*.*";}
				if(sv.ShowDialog() == DialogResult.OK && sv.FileName.Length > 0) {Console.Write(sv.FileName);}
			}
			else if(args[i] == "/test")
			{
				string test = Extension.ToFilter(args[i+1]);
				Console.Write(test);
			}
			else if(args[i] == "/c")
			{
				Point mypoint = Control.MousePosition;
				Console.WriteLine(mypoint);
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


	//public static Extension exe = new Extension("Executable files", "exe|com|msi");
	//public static Extension cmd = new Extension("Dos command files", "bat|cmd");
	//public static Extension iso = new Extension("Disc image files", "iso|img");
	//public static Extension img = new Extension("Image files", "gif|png|jpg|jpeg");
	//public static Extension web = new Extension("Web source code file", "asp|aspx|js|jsp|?htm?|php?");
	//public static Extension code = new Extension("Source code files", "ada|asm|bas|c|cpp|cs|h|java|pas|pl|pm|py|rb|vb|vbs");
	//public static Extension jpg = new Extension("Jpeg image files", "jpg|jpeg");
	//public static Extension db = new Extension("Database files", "db|sql");


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

	public static void DisplayLists()
	{
		for(int i = 0; i < ListAll.Length; i++) {Console.WriteLine("  " + GetName(ListAll[i]) + " : " + GetDescription(ListAll[i]) + " (*." + GetExtension(ListAll[i]) + ")");}
	}

	public static Extension CheckExist(string input)
	{
		for(int i = 0; i < ListAll.Length; i++) {if(input == GetName(ListAll[i])) {return ListAll[i];}}
		return null;
	}
}