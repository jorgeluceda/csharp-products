//0Homework 1 Form
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
		this.Controls.Add(panel1);
	}
	
	//Setting up Panel 2
	private void panelTwo() {
		
	}
	
}
