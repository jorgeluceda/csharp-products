//Homework 1 Form
using System.Windows.Forms;
using System.Drawing;

class FirstForm: Form {
	
	//Input Variable
	string userName;	

	//Panels
	Panel panel1;
	Panel panel2;
	
	//Constructor
	public FirstForm(string formTitle, string userName) {
		this.Text = formTitle;
		this.userName = userName;
        	this.Size = new Size(500, 500);
		this.panelOne();
		this.panelTwo();
	}
	
	//Setting up Panel 1
	private void panelOne() {
		panel1 = new Panel();

		//Coloring Panel
		panel1.BackColor = Color.Orange;
		
		//Sizing Panel
		panel1.Height = 50;
		panel1.Width = 100;
		
		//Docking Panel
		panel1.Dock = DockStyle.Bottom;
		
		//Labeling Panel
		Label label1 = new Label();
		label1.Text = userName;

		//Adding label and panel
		panel1.Controls.Add(label1);
		this.Controls.Add(panel1);
	}
	
	//Setting up Panel 2
	private void panelTwo() {
		panel2 = new Panel();
		
		//Coloring Panel
		panel2.BackColor = Color.SkyBlue;
		
		//Docking Panel
		panel2.Dock = DockStyle.Fill;
		
		//Labeling Panel
		Label label2 = new Label();
		label2.Text = "Comment: ";

		//Adding label and panel
		panel1.Controls.Add(label2);
		this.Controls.Add(panel2);
	}
	
}
