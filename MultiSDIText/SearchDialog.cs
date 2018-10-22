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
        public SearchDialog()
        {
            InitializeComponent();
        }

        List<FileInfo> searchResults;

        #region SearchUserState
        class SearchUserState
        {
            public readonly List<FileInfo> results;
            public readonly int totalFiles;
            public readonly int filesSoFar;

            public SearchUserState(List<FileInfo> results, int totalFiles, int filesSoFar)
            {
                this.results = results;
                this.totalFiles = totalFiles;
                this.filesSoFar = filesSoFar;
            }
        }
        #endregion

        #region Searching File System
        private int getTotalDirectories()
        {
            int total = 0;

            foreach(String drive in Directory.GetLogicalDrives())
            {
                total++;

                foreach(DirectoryInfo child in getDirectories(drive))
                {
                    total++;
                }
            }

            return total;
        }
    
        private void Search(String extension)
        {
            // Report initial progress
            this.SearchBackgroundWorker.ReportProgress(0, new SearchUserState(searchResults, getTotalDirectories(), 0));

            foreach (String drive in Directory.GetLogicalDrives())
            {
                Debug.WriteLine(drive);
                foreach (DirectoryInfo child in getDirectories(drive))
                {
                    Debug.WriteLine(child.FullName);
                    FindFiles(child, extension);
                }
            }
        }

        private void FindFiles(DirectoryInfo dir, String extension)
        {
            try
            {
                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0)
                {
                    foreach (DirectoryInfo child in children)
                    {
                        Debug.WriteLine(child.FullName);
                        FindFiles(child, extension);
                    }
                }
                else
                {
                    FileInfo[] Files = dir.GetFiles(extension);
                    
                    if (Files.Length > 0)
                    {
                        //Found some files with the given extension
                        foreach(FileInfo item in Files)
                        {
                            // Add each file name to a list
                            
                        }
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

        private void startButton_Click(object sender, EventArgs e)
        {
            // Start a worker thread, passing the selected extension from the Combo Box
            this.SearchBackgroundWorker.RunWorkerAsync((String)this.extensionComboBox.SelectedValue);
        }

        private void startButton_Validating(object sender, CancelEventArgs e)
        {
            if(!(this.extensionComboBox.SelectedIndex > -1))
            {
                this.SearchErrorProvider.SetError(this.startButton, 
                    "Please select an extension to search for from the dropdown list below");

                e.Cancel = true;
            }
        }

        private void SearchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // DONT MANIPULATE ANYTHING WITH THE UI HERE!!!!!!!!!!!!!!!!!
            Search((String)e.Argument);
        }

        private void SearchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SearchUserState progress = (SearchUserState)e.UserState;
            ShowProgress(progress.results, progress.totalFiles, progress.filesSoFar);
        }

        private void ShowProgress(List<FileInfo> results, int totalFiles, int filesSoFar)
        {
            // Make sure we're on the UI thread
            Debug.Assert(this.InvokeRequired == false);     
            if (this.InvokeRequired == true) throw new Exception("Invalid Operation: You're on the worker thread!");

            // Display progress in UI
            foreach(FileInfo file in results)
            {
                this.Results.Items.Add(file.FullName);
            }
            this.ProgressBar.Maximum = totalFiles;
            this.ProgressBar.Value = filesSoFar;

            if(filesSoFar == totalFiles)
            {
                // Reset progress UI
                this.ProgressBar.Visible = false;
            }
        }
    }
}
