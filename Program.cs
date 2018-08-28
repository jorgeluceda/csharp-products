using System;
using System.Windows.Forms;

class Program
{
	static void Main(String[] args)
	{
		string name = "No Name Provided";
		string title = "No Title Provided";

		if(args.Length >= 1)
		{
			title = args[0];

			if(args.Length > 1)
				name = args[1];
		}

		Application.Run(new MainForm(title, name));
	}
}
