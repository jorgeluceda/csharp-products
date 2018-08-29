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

        public ExtendedForm(String title, String name)
        {

            this.Text = title;
            this.name = name;
            this.Size = new Size(500, 250);

            Panel panel = new Panel();
            panel.BackColor = Color.Red;
            panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel.Location = new Point(0, 0);

            Label label = new Label();
            label.Text = this.name;
            label.Top = 15;
            label.Left = 15;

            panel.Controls.Add(label);

            TextBox textbox = new TextBox();
            textbox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

            panel.Controls.Add(textbox);

            Button button = new Button();
            button.Text = "Click Me";
            button.Click += new EventHandler(OnClick);

            panel.Controls.Add(button);


            this.Controls.Add(panel);

        }

        public void OnClick(Object sender, EventArgs args)
        {

            MessageBox.Show("textbox.Text");

        }


    }

}
