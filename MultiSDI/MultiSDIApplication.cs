using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;

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

        
    }
}
