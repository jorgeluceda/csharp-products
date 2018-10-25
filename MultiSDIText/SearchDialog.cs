using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MultiSDIText
{
    public partial class SearchDialog : Form
    {
        private TopLevelForm form;

        public TopLevelForm MainForm
        {
            get { return this.form; }
            set { this.form = value; }
        }

        public SearchDialog()
        {
            InitializeComponent();
        }

        #region UserState
        class SearchUserState
        {
            public FileInfo[] results;
            public String extension;

            public SearchUserState(FileInfo[] results, String extension)
            {
                this.results = results;
                this.extension = extension;
            }
        }
        #endregion

        SearchUserState state;

        #region Searching File System
    
        private void Search(String extension)
        {
            // Check for cancellation
            if (this.SearchBackgroundWorker.CancellationPending) return;

            // Initial results is empty list
            FileInfo[] searchResults = new FileInfo[] { };

            // Report initial progress
            this.SearchBackgroundWorker.ReportProgress(0, state = new SearchUserState(searchResults, extension));

            Debug.WriteLine(state.extension);

            foreach (String drive in Directory.GetLogicalDrives())
            {
                // Check for cancellation
                if (this.SearchBackgroundWorker.CancellationPending) return;

                Debug.WriteLine(drive);
                foreach (DirectoryInfo child in getDirectories(drive))
                {
                    // Check for cancellation
                    if (this.SearchBackgroundWorker.CancellationPending) return;

                    Debug.WriteLine(child.FullName);
                    FindFiles(child, state.extension);
                }
            }
        }

        private void FindFiles(DirectoryInfo dir, String extension)
        {
            // Check for cancellation
            if (this.SearchBackgroundWorker.CancellationPending) return;

            try
            {
                // Check for cancellation
                if (this.SearchBackgroundWorker.CancellationPending) return;

                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0)
                {
                    foreach (DirectoryInfo child in children)
                    {
                        // Check for cancellation
                        if (this.SearchBackgroundWorker.CancellationPending) return;

                        Debug.WriteLine(child.FullName);
                        Debug.WriteLine(extension);
                        FindFiles(child, extension);
                    }
                }
                else
                {
                    // Check for cancellation
                    if (this.SearchBackgroundWorker.CancellationPending) return;

                    FileInfo[] Files = dir.GetFiles(extension);

                    if (Files.Length > 0)
                    {
                        //Found some files with the given extension
                        this.SearchBackgroundWorker.ReportProgress(0, state = new SearchUserState(Files, state.extension));
                        Debug.WriteLine(state.extension);

                        // Check for cancellation
                        if (this.SearchBackgroundWorker.CancellationPending) return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool AttrOn(FileAttributes attr, FileAttributes field)
        {
            return (attr & field) == field;
        }

        public DirectoryInfo[] getDirectories(DirectoryInfo dir)
        {
            if (AttrOn(dir.Attributes, FileAttributes.Offline))
            {
                Console.Out.WriteLine(dir.Name + " is not mapped ");
                return new DirectoryInfo[] { };
            }
            if (!dir.Exists)
            {
                Console.Out.WriteLine(dir.Name + " does not exist ");
                return new DirectoryInfo[] { };
            }
            try
            {
                return dir.GetDirectories();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
                return new DirectoryInfo[] { };
            }
        }

        /**
         *  Gets all the directories in a given drive 
         */
        public DirectoryInfo[] getDirectories(String strDrive)
        {
            DirectoryInfo dir = new DirectoryInfo(strDrive);
            return getDirectories(dir);
        }
        #endregion

        #region Search Buttons
        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.SearchBackgroundWorker.CancellationPending)
            {
                return;
            }

            // Tell user we're searching
            this.StatusStripIndicator.Text = "Searching for files with the given extension...";     
            
            // Hide/Show buttons appropriately
            this.stopButton.Visible = true;     
            this.pauseButton.Visible = true;
            this.startButton.Visible = false;

            // Start a worker thread, passing the selected extension from the Combo Box
            this.SearchBackgroundWorker.RunWorkerAsync((String)this.extensionComboBox.GetItemText(this.extensionComboBox.SelectedItem));
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (this.pauseButton.Text == "Pause")
            {
                this.pauseButton.Text = "Continue";

                // PUT LOGIC TO PAUSE SEARCH HERE
            }
            else if (this.pauseButton.Text == "Continue")
            {
                this.pauseButton.Text = "Pause";

                // PUT LOGIC TO CONTINUE SEARCH HERE
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (this.SearchBackgroundWorker.IsBusy)
            {
                this.SearchBackgroundWorker.CancelAsync();
                this.pauseButton.Visible = false;
                this.stopButton.Visible = false;
                this.startButton.Visible = true;
                return;
            }
        }
        #endregion

        #region Validation
        private void startButton_Validating(object sender, CancelEventArgs e)
        {
            if(!(this.extensionComboBox.SelectedIndex > -1))
            {
                this.SearchErrorProvider.SetError(this.startButton, 
                    "Please select an extension to search for from the dropdown list below");

                e.Cancel = true;
            }
        }
        #endregion

        #region BackgroundWorker Event Handlers
        private void SearchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // DONT MANIPULATE ANYTHING WITH THE UI HERE!!!!!!!!!!!!!!!!!
            Search((String)e.Argument);

            if (this.SearchBackgroundWorker.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void SearchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SearchUserState progress = (SearchUserState)e.UserState;
            ShowProgress(progress.results);
            progress.extension = (String)this.extensionComboBox.GetItemText(this.extensionComboBox.SelectedItem);
        }

        private void ShowProgress(FileInfo[] results)
        {
            // Make sure we're on the UI thread
            Debug.Assert(this.InvokeRequired == false);     
            if (this.InvokeRequired == true) throw new Exception("Invalid Operation: You're on the worker thread!");

            // Display progress in UI
            foreach(FileInfo file in results)
            {
                this.Results.Items.Add(file.FullName);
            }
        }

        private void SearchBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.StatusStripIndicator.Text = "Ready";   // Reset Status Strip

            if(e.Error != null)
            {
                this.Results.Text = e.Error.Message;
                return;
            }

            if (e.Cancelled)
            {
                MessageBox.Show("The search has successfully cancelled.");
                return;
            }

            MessageBox.Show("Files Found: " + this.Results.Items.Count);    // Display a MessageBox showing how many files were found upon completion
        }
        #endregion

        #region Search Dialog Event Handlers
        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.SearchBackgroundWorker.IsBusy)
            {
                this.SearchBackgroundWorker.CancelAsync();
                this.MainForm.SearchDlg = null;
            }
        }
        #endregion
    }
}
