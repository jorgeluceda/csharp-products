using System;
using System.Drawing;
using System.Windows.Forms;

/*
    The main Form class
    contains the constructor and all methods needed
    for our form
*/
class MainForm : Form
{
	// Names and titles for our Form instance
	private string name;
	private string title;

    public MainForm(string title, string name)
    {
        this.title = title;
        this.name = name;
        this.SetupComponents();
    }

    private void SetupComponents()
    {
        // The form
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Size = new Size(600, 370);
        this.Name = "MainForm";
        this.Text = this.title;

    }
}

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



