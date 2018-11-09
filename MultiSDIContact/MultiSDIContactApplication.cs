using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MultiSDIContact
{
    class MultiSDIContactApplication : WindowsFormsApplicationBase
    {

        #region Member Variables & Properties
        static MultiSDIContactApplication application;
        #endregion
        #region Application Getter
        /**
         *  Getter for the Application. Returns a single instance only. If one doesn't exist, it is created and returned.
         *  If one does exist, that one is returned.
         */
        internal static MultiSDIContactApplication Application
        {
            get
            {
                if (application == null)
                    application = new MultiSDIContactApplication();
                return application;
            }
        }
        #endregion

        #region Constructor
        /**
         *  Constructor. Sets the Application to Single Instance & sets the shut down style to only shut down after
         *  all top level forms have been closed.
         */
        public MultiSDIContactApplication()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }
        #endregion

        #region Overriden Methods
        /**
         *  OnCreateMainForm sets the Application's main form to a new ContactDirectoryForm created with the 
         *  command line args.
         */
        protected override void OnCreateMainForm()
        {
            this.MainForm = this.CreateContactDirectoryWindow(this.CommandLineArgs);
        }

        /**
         *  OnStartUpNextInstance handles subsequent requests to launch the application. 
         */
        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
            this.CreateContactDirectoryWindow(e.CommandLine);
        }
        #endregion

        #region ContactDirectoryForm methods
        /**
         *  CreateContactDirectoryWindow helper method. Parses the command line args and grabs the file name, then passes the file
         *  name to ContactDirectoryForm's CreateContactDirectoryWindow method to create a Top Level Window with the given file name.
         */
        ContactDIrectoryForm CreateContactDirectoryWindow(ReadOnlyCollection<string> args)
        {
            // Get file name, if provided
            string fileName = (args.Count > 0 ? args[0] : null);

            // Create new top level form
            return ContactDIrectoryForm.CreateContactDirectoryWindow(fileName);
        }

        /**
         *  AddContactDirectoryForm helper method. Takes a form as a param and points its Activated and FormClosed events
         *  to handlers implemented in MultiSDIApplication. It also sets the first form of the application instance
         *  to the MainForm of the application.
         */
        public void AddContactDirectoryForm(Form form)
        {
            // Add handlers for the form's Activated and FormClosed events
            form.Activated += Form_Activated;
            form.FormClosed += Form_FormClosed;

            // If there's only one OpenForm, make it the MainForm
            if (this.OpenForms.Count == 1)
                this.MainForm = form;
        }

        /**
         *  AddWindowMenu helper method. Takes a windowMenu (Menu Item) and adds a handler found in MultiSDIApplication's
         *  Event Handlers to the menu item's DropDownOpening event.
         */
        public void AddWindowMenu(ToolStripMenuItem windowMenu)
        {
            windowMenu.DropDownOpening += windowMenu_DropDownOpening;
        }
        #endregion

        #region EventHandlers
        /**
         *  Activated event handler for ContactDirectoryForm. Sets the application's MainForm to the 
         *  ContactDirectoryForm that was Activated.
         */
        void Form_Activated(object sender, EventArgs e)
        {
            this.MainForm = (Form)sender;
        }

        /**
         *  FormClosed event handler for ContactDirectoryForm. Checks if the ContactDirectoryForm that was closed 
         *  is the MainForm AND there are more forms in this Application instance. If yes, then we set 
         *  this Application instance's MainForm to the first form in OpenForms. We also remove the
         *  form that was closed from the list of form's whose Activated/FormClosed events are handled
         *  by the handlers.
         */
        void Form_FormClosed(object sender, EventArgs e)
        {
            // Set a new MainForm if necessary
            if (((Form)sender == this.MainForm) && (this.OpenForms.Count > 0))
                this.MainForm = (Form)this.OpenForms[0];

            // Take the sender (form that was closed) and remove it from the list of forms whose Activated/FormClosed 
            // event is handled by those handlers
            Form form = sender as Form;
            form.Activated -= Form_Activated;
            form.FormClosed -= Form_FormClosed;
        }

        /**
         *  DropDownOpening event handler for the WindowMenu (menu listing all open ContactDirectoryForm).
         *  Clears the current window menu, then creates a new one, populating the menu with all of the 
         *  currently open ContactDirectoryForm (OpenForms). Shows a check mark next to the current MainForm.
         */
        public void windowMenu_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;

            // Clear the current menu
            if (menu.DropDownItems.Count > 0)
                menu.DropDown.Dispose();

            // Create a new DropDown menu object
            menu.DropDown = new ToolStripDropDown();

            // Populate the menu with one item for each open top level form
            foreach (Form form in this.OpenForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = form.Text;
                item.Tag = form;
                menu.DropDownItems.Add(item);
                item.Click += WindowMenuItem_Click;

                // Check menu item that represents currently active window
                if (form == this.MainForm)
                    item.Checked = true;
            }
        }

        /**
         *  Click handler for a WindowMenuItem. When Window->Item (ContactDirectoryForm) is clicked, we activate that form. 
         */
        void WindowMenuItem_Click(object sender, EventArgs e)
        {
            // Activate ContactDirectoryForm based on selection
            ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        }
        #endregion
    }
}
