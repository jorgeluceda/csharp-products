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

    // All declaration controls
    private Panel bottomPanel;
    private ListBox lbControls;
    private Label lblName;
    private Panel topPanel;
    private Button btnShowComment;
    private TextBox txtComment;
    private Label lblComment;

    public MainForm(string title, string name)
    {
        this.title = title;
        this.name = name;
        this.SetupComponents();
    }

    private void SetupComponents()
    {
        this.bottomPanel = new Panel();
        this.lbControls = new ListBox();
        this.lblName = new Label();
        this.topPanel = new Panel();
        this.lblComment = new Label();
        this.txtComment = new TextBox();
        this.btnShowComment = new Button();

        // bottomPanel 
        this.bottomPanel.BackColor = ColorTranslator.FromHtml("#865FC5");
        this.bottomPanel.Controls.Add(this.lblName);
        this.bottomPanel.Controls.Add(this.lbControls);
        this.bottomPanel.Dock = DockStyle.Bottom;
        this.bottomPanel.Left = 0;
        this.bottomPanel.Top = 97;
        this.bottomPanel.Name = "bottomPanel";
        this.bottomPanel.Size = new Size(1135, 242);

        // lbControls
        this.lbControls.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.lbControls.Left = 12;
        this.lbControls.Top = 47;
        this.lbControls.Name = "lbControls";
        this.lbControls.Size = new Size(1111, 184);

        // lblName
        this.lblName.AutoSize = true;
        this.lblName.ForeColor = System.Drawing.Color.White;
        this.lblName.Left = 12;
        this.lblName.Top = 12;
        this.lblName.Name = "lblName";
        this.lblName.Size = new Size(51, 20);
        this.lblName.TabIndex = 1;
        this.lblName.Text = this.name;

        // topPanel
        this.topPanel.BackColor = ColorTranslator.FromHtml("#3E3E42");
        this.topPanel.Controls.Add(this.btnShowComment);
        this.topPanel.Controls.Add(this.txtComment);
        this.topPanel.Controls.Add(this.lblComment);
        this.topPanel.Dock = DockStyle.Fill;
        this.topPanel.Name = "topPanel";
        this.topPanel.Size = new Size(1135, 97);

        // lblComment
        this.lblComment.AutoSize = true;
        this.lblComment.ForeColor = System.Drawing.Color.White;
        this.lblComment.Left = 12;
        this.lblComment.Top = 18;
        this.lblComment.Name = "lblComment";
        this.lblComment.Size = new Size(82, 20);
        this.lblComment.Text = "Comment:";

        // txtComment
        this.txtComment.Anchor = AnchorStyles.Top | AnchorStyles.Left| AnchorStyles.Right;
        this.txtComment.Left = 75;
        this.txtComment.Top = 15;
        this.txtComment.Name = "txtComment";
        this.txtComment.Size = new Size(1048, 26);

        // btnShowComment
        this.btnShowComment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnShowComment.Left = 972;
        this.btnShowComment.Top = 53;
        this.btnShowComment.ForeColor = Color.White;
        this.btnShowComment.BackColor = ColorTranslator.FromHtml("#865FC5");
        this.btnShowComment.Name = "btnShowComment";
        this.btnShowComment.Size = new Size(152, 32);
        this.btnShowComment.Text = "Show Comment...";
        this.btnShowComment.Click += this.Button_Click;

        // The form
        this.AutoScaleMode = AutoScaleMode.Font;
        //specify a the form size
        this.Size = new Size(600, 370);
        this.Name = "MainForm";
        this.Text = this.title;
        this.Controls.Add(this.topPanel);
        this.Controls.Add(this.bottomPanel);

        // Add all controls to the list box
        this.RecursivelyFillControlsName(this.lbControls, this.Controls);
    }

    /**
     * Add listener for button click event
     */
    private void Button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello " + this.name + ":\n" + this.txtComment.Text);
    }

    /**
     * Recursively fill a list box with the names of all the controls in the collection
     */
    private void RecursivelyFillControlsName(ListBox list, Control.ControlCollection controls,
                                                string prefix = "")
    {
        foreach(Control control in controls)
        {
            string controlName = prefix + 
                    (string.IsNullOrWhiteSpace(control.Name) ? control.GetType().Name : control.Name);

            string controlCenter = prefix + 
                    (string.IsNullOrWhiteSpace(control.Name) ? control.GetType().Name : control.Name);
                    
            list.Items.Add(controlName);

            if (control.Controls.Count > 0)
                this.RecursivelyFillControlsName(list, control.Controls, controlName + " -> ");
        }
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



