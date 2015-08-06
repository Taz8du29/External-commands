using System;
using System.Net;

class dummy
{[STAThread]
	public static void Main(string[] args)
	{
		WebClient client = new WebClient();
		string response = client.DownloadString(args[0]);

		string final = htmlAccents(response);

		Console.WriteLine(final);
	}

	public static string htmlAccents(string inputText) {
		string[] html = {
			"&Agrave;", "&Aacute;", "&Acirc;", "&Atilde;", "&Auml;", "&Aring;", "&agrave;", "&aacute;", "&acirc;", "&atilde;", "&auml;", "&aring;",
			"&Egrave;", "&Eacute;", "&Ecirc;", "&Euml;", "&egrave;", "&eacute;", "&ecirc;", "&euml;",
			"&Igrave;", "&Iacute;", "&Icirc;", "&Iuml;", "&igrave;", "&iacute;", "&icirc;", "&iuml;",
			"&Ograve;", "&Oacute;", "&Ocirc;", "&Otilde;", "&Ouml;", "Oslash;", "&ograve;", "&oacute;", "&ocirc;", "&otilde;", "&ouml;", "&oslash",
			"&Ugrave;", "&Uacute;", "&Ucirc;", "&Uuml;", "&ugrave;", "&uacute;", "&ucirc;", "&uuml;",
			"&Yacute;", "&Yuml;", "&yacute;", "&yuml;",
			"&Ccedil;", "&ccedil;",
			"&Ntilde;", "&ntilde;",
			"&szlig", "&AElig;", "&aelig;", "&OElig;", "&oelig;",
			"&euro;", "&pound;", "&yen;", "&cent;", "&curren;",
			"&copy;", "&reg;",
			"&deg;", "&percnt;", "&amp;", "&Hat;", "&uml;", "&quot;", "&micro;", "&para;", "&semi;", "&commat;", "&colon;", "&lowbar;",
			"&lt;", "&gt;", "&lpar;", "&rpar;", "&laquo;", "&raquo;", "&lbrace;", "&rbrace;", "&bsol;", "&sol;",
			"&excl;", "&quest;", "&iexcl;", "&iquest;"
		};

		string[] accents = {
			"À", "Á", "Â", "Ã", "Ä", "Å", "à", "á", "â", "ã", "ä", "å",
			"È", "É", "Ê", "Ë", "è", "é", "ê", "ë",
			"Ì", "Í", "Î", "Ï", "ì", "í", "î", "ï",
			"Ò", "Ó", "Ô", "Õ", "Ö", "Ø", "ò", "ó", "ô", "õ", "ö", "ø",
			"Ù", "Ú", "Û", "Ü", "ù", "ú", "û", "ü",
			"Ý", "Ÿ", "ý", "ÿ",
			"Ç", "ç",
			"Ñ", "ñ",
			"ß", "Æ", "æ", "Œ", "œ",
			"€", "£", "¥", "¢", "¤",
			"©", "®",
			"°", "%", "&", "^", "¨", "\"", "µ", "¶", ";", "@", ":", "_",
			"<", ">", "(", ")", "«", "»", "{", "}", "\\", "/",
			"!", "?", "¡", "¿"
		};

		for(int i = 0; i < html.Length; i++) {
			inputText = inputText.Replace(html[i], accents[i]);
		}

		return inputText; 
	}
}