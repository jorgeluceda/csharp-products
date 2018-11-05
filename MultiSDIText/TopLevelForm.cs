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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CoreLibrary;
using MultiSDIText.Storage;
using System.Runtime.InteropServices;

namespace MultiSDIText
{
    public partial class TopLevelForm : Form
    {
        #region Member Variables and Properties
        string fileName;

        Point downPoint = Point.Empty;

        //represents our document (a list of text objects and their functionality)
        Storage.Document doc = new Storage.Document();

        Storage.Text curText = new Storage.Text();

        SearchDialog searchDialog;
        public SearchDialog SearchDialog
        {
            get { return this.searchDialog; }
            set { this.searchDialog = value; }
        }

        /*
         * Ommit for data binding - don't want to directly modify
         * 
        public Document Document
        {
            get { return this.doc; }
            set { this.doc = value; }
        } */

        //represents our current text to be added to the document
        //Storage.Text curText = new Storage.Text();
        int Zorder = 0;
        //OptionsForm optionsForm = new OptionsForm();
        TextOptions optionsForm = new TextOptions();
        GridViewForm gridViewForm = new GridViewForm();


        // Read Only FileName property
        string FileName
        {
            get { return this.fileName; }
        }

        //Using Interop to make a custom cursor called AnimatedCursor
        [DllImport("user32.dll")]
        static extern IntPtr LoadCursorFromFile(string lpFileName);
        static Cursor AnimatedCursor;

        #endregion
        #region Constructor
        public TopLevelForm()
        {
            InitializeComponent();

            //initializing a current shape
            InitializeDS();
              
            // When an instance of TopLevelForm is created, add it to the MultiSDIApplication context
            MultiSDITextApplication.Application.AddTopLevelForm(this);

            //Set the applications windowmenu
            MultiSDITextApplication.Application.AddWindowMenu(this.windowToolStripMenuItem);
        }

        //Static constructor to create the animated cursor
        static TopLevelForm()
        {
            //Getting the path to the animated cursor from Resources
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\spinCursor.ani", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            //Load Animated Cursor
            IntPtr cursor = LoadCursorFromFile(FileName);
            AnimatedCursor = new Cursor(cursor);
        }

        #endregion

        #region Helper Methods

        private void docPictureBox_Paint(object sender, PaintEventArgs e)
        {

            // Create a local version of the graphics object for the PictureBox.
            Graphics docGraphics = e.Graphics;


            this.doc.Draw(docGraphics);
        }
        private void docPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            
            if (doc.Find(coordinates) != null)  //check to see if click is inside a text object
            {
                if (me.Button.ToString() == "Right") //checks to see if a right click
                {
                    this.optionsForm.ShowDialog();  //opens options if right click on a text object

                    if (this.optionsForm.closeAccept == true)
                    {
                        this.docPictureBox.Invalidate();
                    }

                    return;
                }
                if (me.Button.ToString() == "Left") //checks to see if a right click
                {
                    backToolStripStatusLabel.BackColor = this.curText.BackgroundColor;
                    colorToolStripStatusLabel.BackColor = this.curText.Color;
                    fontToolStripStatusLabel.Text = "Font: " + this.curText.Font.Name;
                }
                this.curText = doc.Find(coordinates);//change current text to the found object
                return;
            }

            InsertText("text", coordinates);


        }


        /**
         *  CreateTopLevelWindow implements creating a new form. This is the real 'constructor'. 
         *  First, we check if the fileName matches any of the Open Forms in the MultiSDIApplication. If it
         *  does, we just activate that form. If it doesn't we create a new one using OpenFile, a method found
         *  in this class (TopLevelForm) to open a file, then we activate the new window.
         */
        public static TopLevelForm CreateTopLevelWindow(string fileName)
        {
            // If fileName is not empty
            if (!string.IsNullOrEmpty(fileName))
            {
                // Loop through the open forms in MultiSDIApplication 
                foreach (TopLevelForm openForm in Application.OpenForms)
                {
                    // If the file we're trying to open is already open, i.e. file names match
                    if (string.Compare(openForm.fileName, fileName, true) == 0)
                    {
                        // Bring form to top
                        openForm.Activate();
                        return openForm;
                    }
                }
            }

            // Otherwise, create a new one with the given fileName
            TopLevelForm form = new TopLevelForm();
            form.OpenFile(fileName);
            form.Show();

            // Bring form to top
            form.Activate();
            return form;
        }
        /**
         *  OpenFile opens a file given it's fileName. Sets this top level form's file name to the fileName passed
         *  in the call, and then populates this form with the contents of the document.
         */
        void OpenFile(string fileName)
        {
            this.fileName = fileName;
            
            // If fileName is not empty
            if (!string.IsNullOrEmpty(fileName))
            {
                // Populate this Window with the shapes from the document tied to fileName
            }
            else
            {

            }
        }


        #endregion


        private void InitializeDS()
        {
            /* Take a look at code below to understand the data binding */
            

            /*
            Text text = new Text();
            text.Content = "Hello";
            text.Location = new Point(100, 200);
            text.BackgroundColor = Color.White;
            
            Text text2 = new Text();
            text2.Content = "Hello2";
            text2.Location = new Point(100, 200);
            doc.Add(text);
            doc.Add(text2);
            
            */

            this.optionsForm.DataBindingSource.DataSource = doc.content;
            this.gridViewForm.DataBindingSource.DataSource = doc.content;
            
            //.DataBindingSource.DataSource = doc.content;

            docPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.docPictureBox_Paint);

            fontToolStripStatusLabel.Text =  "Times New Roman";

        }

        #region Serialization Handlers
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Text != "Typography++")
            {
                using (Stream stream = new FileStream(this.Text, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, doc);
                }
            }
            else
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    if (dlg.ShowDialog() != DialogResult.OK) return;

                    using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, doc);
                        this.Text = dlg.FileName;
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                using (Stream stream =
                    new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, doc);
                    this.Text = dlg.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream =
                    new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    Document document = (Document)formatter.Deserialize(stream);
                    TopLevelForm form = CreateTopLevelWindow(dlg.FileName);
                    form.doc = document;
                    form.Text = dlg.FileName;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTopLevelWindow(null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.searchDialog = new SearchDialog();

            foreach(Form form in MultiSDITextApplication.Application.OpenForms)
            {
                if (form.Name == this.searchDialog.Name) {
                    this.searchDialog.BringToFront();
                    return;
                }
            }
            this.searchDialog.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.optionsForm.listBoxDoc.DisplayMember = "Content";
            this.optionsForm.ShowDialog();
            

            if(this.optionsForm.closeAccept == true)
            {
                backToolStripStatusLabel.BackColor = this.curText.BackgroundColor;
                colorToolStripStatusLabel.BackColor = this.curText.Color;
                fontToolStripStatusLabel.Text = "Font: " + this.curText.Font.Name;
                this.docPictureBox.Invalidate();
            
            }
            
            if(this.optionsForm.bringToInt == 1) //send text to back
            {
                Text tempText = doc.content[this.optionsForm.boundZOrder];
                doc.content.RemoveAt(this.optionsForm.boundZOrder);

                tempText.ZOrder = 0;
                doc.content.Insert(0, tempText);

                int count = 0;
                foreach (Text curText in doc.content)
                {
                    curText.ZOrder = count;
                    count++;
                    
                }
                


            }

            if (this.optionsForm.bringToInt == 2) //bring text to front
            {
                Text tempText = doc.content[this.optionsForm.boundZOrder];
                doc.content.RemoveAt(this.optionsForm.boundZOrder);

                tempText.ZOrder = (Zorder - 1); //zorder was previously incremented

                foreach(Text curText in doc.content)
                {
                    if(curText.Content != tempText.Content || 
                            curText.Location != tempText.Location)
                    {
                        curText.ZOrder--;

                    }
                }
                doc.Add(tempText);

            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlainTextDialog dlg = new PlainTextDialog();

            dlg.ShowDialog();
            
            if(dlg.closeAccept == true)
      
            {
                foreach(Text textToAdd in dlg.plainTextDoc.content)
                {
                    textToAdd.ZOrder = Zorder;
                    Zorder += 1;
                    textToAdd.Color = Color.Blue;
                    textToAdd.BackgroundColor = Color.Transparent;

                    textToAdd.Font = new Font("Times New Roman", 12.0f);

                    doc.Add(textToAdd);
                }
                this.docPictureBox.Invalidate();

            }
        }

        private void TopLevelForm_KeyDown(object sender, KeyEventArgs e)
        {

            // left arrow = 37
            // up arrow = 38
            // right arrow= 39
            // down arrow = 40
            switch ((int)e.KeyCode)
            {
                case 37:
                    //move current text object to left
                    curText.locationX -= 4;
                    //this.doc.Add(curText);
                    statusToolStripStatusLabel.Text = "Moving Left: " + curText.locationX;

                    //optionsForm.DataBindingSource.DataSource = doc.content;
                    this.optionsForm.RefreshItems();
                    this.docPictureBox.Invalidate();
                    break;
                case 38:
                    curText.locationY -= 4;
                    statusToolStripStatusLabel.Text = "Moving Up: " + curText.locationY;

                    //move current text object up
                    this.optionsForm.RefreshItems();
                    this.docPictureBox.Invalidate();
                    ;
                    break;
                case 39:
                    //move current text object to right
                    curText.locationX += 4;
                    statusToolStripStatusLabel.Text = "Moving Right: " + curText.locationX;

                    //move current text object up
                    this.optionsForm.RefreshItems();
                    this.docPictureBox.Invalidate();

                    break;
                case 40:
                    //move current text object downs
                    curText.locationY += 4;
                    statusToolStripStatusLabel.Text = "Moving Down: " + curText.locationY;

                    //move current text object up
                    this.optionsForm.RefreshItems();
                    this.docPictureBox.Invalidate();

                    break;
                default:
                    break;
            }

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                capsToolStripStatusLabel.Text = "CapsLock: ON";
                capsToolStripStatusLabel.BackColor = Color.GreenYellow;
            }
            else
            {
                capsToolStripStatusLabel.Text = "CapsLock: OFF";
                capsToolStripStatusLabel.BackColor = this.BackColor;

            }

        }

        private void docPictureBox_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Left) return;   // If the event is not a left mouse click event, exit
            downPoint = new Point(e.X, e.Y);
            this.curText = doc.Find(e.Location);
            statusToolStripStatusLabel.Text = "Text Selected";



        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oathDialog oath = new oathDialog();
            oath.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDialog help = new HelpDialog();
            help.Show();
        }
        
        private void docPictureBox_MouseMove(object sender, MouseEventArgs e)
        {


                if (downPoint == Point.Empty) return;       // Check for empty downPoint (anomaly case)

                Point location = new Point(e.X, e.Y);
                if(curText != null) {
                    this.curText.Location = location;           // change text location to mouse location
                    this.optionsForm.RefreshItems();            // refresh items
                    this.docPictureBox.Invalidate();
                }

        }

        private void docPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;  // If the event is not a left mouse click event, exit
            downPoint = Point.Empty;                    // Reset the downPoint back to empty 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog dlg = new aboutDialog();
            dlg.Show();
        }

        private void importTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchDialog != null)
            {
                PlainTextDialog dlg = new PlainTextDialog();
                dlg.ShowDialog();

                if (!String.IsNullOrEmpty(this.searchDialog.FileContents) && !String.IsNullOrWhiteSpace(this.searchDialog.FileContents))
                {
                    dlg.PlainTextTextBox.Text = this.searchDialog.FileContents;
                }

                if (dlg.closeAccept == true)
                {
                    foreach (Text textToAdd in dlg.plainTextDoc.content)
                    {
                        textToAdd.ZOrder = Zorder;
                        Zorder += 1;
                        textToAdd.Color = Color.Blue;
                        textToAdd.BackgroundColor = Color.Transparent;

                        textToAdd.Font = new Font("Times New Roman", 12.0f);

                        doc.Add(textToAdd);
                    }
                    this.docPictureBox.Invalidate();
                }
            }

        }

        //When mouse is over the docPic area
        private void docPictureBox_MouseEnter(object sender, EventArgs e)
        {
            //Change cursor to the animated cursor
            this.Cursor = AnimatedCursor;
        }

        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gridViewForm.ShowDialog();
            this.docPictureBox.Invalidate();
        }

        private void DragAndDrop()
        {

        }

        private void TopLevelForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)) )
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;

            }
        }

        private void TopLevelForm_DragOver(object sender, DragEventArgs e)
        {

        }

        private void TopLevelForm_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            // Get the current cursor position, relative to the form
            //Point cursorPosition = this.PointToClient(Cursor.Position);
            // Cancel the drag and drop operation if the cursor
            // is dragged outside the form
            //if (this.docPictureBox.Contains(this.PointToClient(Cursor.Position)))
            if( this.docPictureBox.ClientRectangle.Contains(this.PointToClient(Cursor.Position)) )
            {
                e.Action = DragAction.Cancel;
     
            }
            Console.WriteLine("Outside");
        }

        private void TopLevelForm_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve drag data
            string sourceText = (string)e.Data.GetData(typeof(string));


            DragEventArgs me = (DragEventArgs)e;
            Point coordinates = this.PointToClient(new Point(e.X, e.Y));

            if (doc.Find(coordinates) != null)  //check to see if click is inside a text object
            {
                backToolStripStatusLabel.BackColor = this.curText.BackgroundColor;
                colorToolStripStatusLabel.BackColor = this.curText.Color;
                fontToolStripStatusLabel.Text = "Font: " + this.curText.Font.Name;

                this.curText = doc.Find(coordinates);//change current text to the found object
                return;
            }

            InsertText(sourceText, coordinates);


        }

        private void InsertText(String insertText, Point coordinates)
        {

            Storage.Text curText = new Storage.Text();


            curText.ZOrder = Zorder;
            Zorder += 1;
            curText.Content = insertText;
            curText.Color = Color.Blue;
            curText.BackgroundColor = Color.Transparent;

            curText.Location = coordinates;
            curText.Font = new Font("Times New Roman", 12.0f);


            this.doc.Add(curText);


            optionsForm.DataBindingSource.DataSource = doc.content;
            this.optionsForm.RefreshItems();
            this.docPictureBox.Invalidate();
            this.curText = curText;                     //change the current text to the new object

        }

        private void MainMenu_MouseEnter(object sender, EventArgs e)
        {
            //Change cursor to the animated cursor
            this.Cursor = AnimatedCursor;
        }
    }
}
