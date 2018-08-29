using System;
using System.Windows.Forms;
using System.Drawing;
//using System.Drawing.Color;


namespace WindowsFormProkect
{

    class Default
    {

        public static void Main(String[] args)
        {

            String firstArg = "Project1";
            String secondArg = "Lazaro B Alvarez";

            if (args.Length > 1)
            {

                firstArg = args[1];
                secondArg = args[2];

            }

            Form form = new ExtendedForm(firstArg, secondArg);
            Application.Run(form);

        }

    }

    class ExtendedForm : Form
    {

        private String name;
        private TextBox textbox;
        private List<Control> ControlList;

        public ExtendedForm(String title, String name)
        {

            this.Text = title;
            this.name = name;
            this.Size = new Size(500, 250);

            Panel panelOne = new Panel();
            panelOne.BackColor = Color.Red;
            panelOne.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelOne.Location = new Point(0, 0);

            Label label = new Label();
            label.Text = this.name;
            label.Top = 15;
            label.Left = 15;

            panelOne.Controls.Add(label);

            Panel panelTwo = new Panel();
            panelTwo.BackColor = Color.Red;
            panelTwo.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelTwo.Location = new Point(0, 0);

            Label labelTwo = new Label();
            labelTwo.Text = "Comment";
            labelTwo.Top = 15;
            labelTwo.Left = 15;

            panelTwo.Controls.Add(labelTwo);

            textbox = new TextBox();
            textbox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

            panelTwo.Controls.Add(textbox);

            Button button = new Button();
            button.Text = "Click Me";
            button.Click += new EventHandler(OnClick);

            panelTwo.Controls.Add(button);


            this.Controls.Add(panelOne);
            this.Controls.Add(panelTwo);

            ControlList = new List<Control>();
            ListControls(this.Controls);

        }

        public void OnClick(Object sender, EventArgs args)
        {

            MessageBox.Show(this.textbox.Text);

        }

        public void ListControls(Control controls)
        {
            Console.WriteLine("Controls");

            foreach (Control c in container.Controls)
            {
                ListControls(c);
                this.ControlList.Add(c);
            }

        }


    }

}
