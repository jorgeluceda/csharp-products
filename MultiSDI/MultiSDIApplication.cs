using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MultiSDI
{
    class MultiSDIApplication : WindowsFormsApplicationBase
    {
        static MultiSDIApplication application;

        /**
         *  Getter for the Application. Returns a single instance only. If one doesn't exist, it is created and returned.
         *  If one does exist, that one is returned.
         */
        internal static MultiSDIApplication Application
        {
            get
            {
                if (application == null)                            
                    application = new MultiSDIApplication();
                return application;                                
            }
        }

        /**
         *  Constructor. Sets the Application to Single Instance & sets the shut down style to only shut down after
         *  all top level forms have been closed.
         */
        public MultiSDIApplication()
        {
            this.IsSingleInstance = true;                          
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;   
        }

        /**
         *  OnCreateMainForm sets the Application's main form to a new TopLevelForm created with the 
         *  command line args.
         */
        protected override void OnCreateMainForm()
        {
            this.MainForm = this.CreateTopLevelWindow(this.CommandLineArgs);
        }

        /**
         *  OnStartUpNextInstance handles subsequent requests to launch the application. 
         */
        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
            this.CreateTopLevelWindow(e.CommandLine);
        }

        /**
         *  CreateTopLevelWindow helper method. Parses the command line args and grabs the file name, then passes the file
         *  name to TopLevelForm's CreateTopLevelWindow method to create a Top Level Window with the given file name.
         */
        TopLevelForm CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            // Get file name, if provided
            string fileName = (args.Count > 0 ? args[0] : null);

            // Create new top level form
            return TopLevelForm.CreateTopLevelWindow(fileName);
        }

        /**
         *  AddTopLevelForm helper method. Takes a form as a param and points its Activated and FormClosed events
         *  to handlers implemented in MultiSDIApplication. It also sets the first form of the application instance
         *  to the MainForm of the application.
         */
        public void AddTopLevelForm(Form form)
        {
            // Add handlers for the form's Activated and FormClosed events
            form.Activated += Form_Activated;
            form.FormClosed += Form_FormClosed;

            // If there's only one OpenForm, make it the MainForm
            if (this.OpenForms.Count == 1)
                this.MainForm = form;
        }

        /**
         *  Activated event handler for TopLevelForms. Sets the application's MainForm to the 
         *  TopLevelForm that was Activated.
         */
        void Form_Activated(object sender, EventArgs e)
        {
            this.MainForm = (Form)sender;
        }

        /**
         *  FormClosed event handler for TopLevelForms. Checks if the TopLevelForm that was closed 
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
    }
}
