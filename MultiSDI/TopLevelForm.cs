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
using SingleDocumentInterface;
using static MultiSDI.Shape;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CoreLibrary;
namespace MultiSDI
{
    public partial class TopLevelForm : BaseMainForm
    {

        #region Member Variables and Properties
        string fileName;
        //Pen pen;
        int Xthis = 100;
        int Ythis = 100;
        float xEndPoint = 0;
        float yEndPoint = 0;
        Boolean loadFlag = true;
        Document doc = new Document();
        OptionsForm optionsForm = new OptionsForm();
        Graphics dc = null;
        List<ToolStripDropDownItem> menuOwners = new List<ToolStripDropDownItem>();


        // Read Only FileName property
        string FileName
        {
            get { return this.fileName; }
        }
        #endregion

        #region Constructor
        public TopLevelForm()
        {
            InitializeComponent();

            InitializeDS();


            // When an instance of TopLevelForm is created, add it to the MultiSDIApplication context
            MultiSDIApplication.Application.AddTopLevelForm(this);

            // Set the application's WindowMenu
            MultiSDIApplication.Application.WindowMenu = this.windowToolStripMenuItem;

            // Add the handler for the DropDownOpening event to the application's window menu
            MultiSDIApplication.Application.WindowMenu.DropDownOpening += MultiSDIApplication.Application.windowMenu_DropDownOpening;
            InitializeSubmenuEvents();

        }
        #endregion

        #region Helper Methods
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
                foreach(TopLevelForm openForm in Application.OpenForms)
                {
                    // If the file we're trying to open is already open, i.e. file names match
                    if(string.Compare(openForm.fileName, fileName, true) == 0)
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

            // TODO: Implement populating the TopLevelForm with the shapes from the saved document. This part will differ
            // from the book, which reads text into the top level forms textbox. We, however, are not dealing with text, but
            //  with shapes

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

        #region MainMenu Item Handlers
        private void shapeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO get actual shape that is going to be edited. EX:
            //
            // Shape shape  = this.SelectedForm.GetShape();
            // this.optionsForm.DataBindingSource.DataSource = shape;

            //this.optionsForm.ShowDialog();

            ///////// TESTING ///////////

            /* Take a look at code below to understand the data binding */
            /*var shape = new Shape();
            shape.LocationX = 300;
            shape.PenType = PenTypeEnum.Dashed;
            var bs = new BindingSource();

            //var dg = new OptionsForm();
            this.optionsForm.DataBindingSource.DataSource = shape;
            //dg.DataBindingSource.DataSource = shape;*/
            var result = this.optionsForm.ShowDialog();
            result.Equals("AAAA");
        }

        /**
         * Click handler for File->Open. Opens a file using an OpenFileDialog, passing the fileName to 
         * CreateTopLevelWindow.
         */
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Our files (*.drw)|*.drw|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CreateTopLevelWindow(dlg.FileName);
            }
        }

        /**
         *  Click handler for File->New. Creates a new top level window, passing null as the fileName. 
         */
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTopLevelWindow(null);
        }
        #endregion

        private void TopLevelForm_Paint(object sender, PaintEventArgs e)
        {
            //doc.Draw(e.Graphics);
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OathDialog dlg = new OathDialog();
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "OathDialog")
                {
                    return;
                }
            }

            dlg.Owner = this;
            dlg.StartPosition = FormStartPosition.Manual;
            dlg.SetDesktopLocation((this.DesktopLocation.X - dlg.Width), this.DesktopLocation.Y);
            dlg.Show();



        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutDialog dlg = new AboutDialog();

            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "AboutDialog")
                {
                    return;
                }
            }

            dlg.Owner = this;
            dlg.StartPosition = FormStartPosition.Manual;
            dlg.SetDesktopLocation((this.DesktopLocation.X + this.Width), this.DesktopLocation.Y);
            dlg.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the document is new, i.e. has never been saved before
            if (string.IsNullOrEmpty(this.doc.DocumentTitle) || string.IsNullOrWhiteSpace(this.doc.DocumentTitle))
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.DefaultExt = ".drw";
                    dlg.Filter = "Drawing files (*.drw)|*.drw";
                    if (dlg.ShowDialog() != DialogResult.OK) return;

                    using (Stream stream =
                        new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                    {
                        IFormatter formatter = new BinaryFormatter();

                        Document doc = new Document();

                        /******
                        //doc.Graph = this.Graph;

                        //doc.DocumentTitle = Path.GetFileName(dlg.FileName);
                        //doc.FilePath = dlg.FileName;
                        ******/

                        formatter.Serialize(stream, doc);
                        this.doc = doc;
                    }

                }

                //this.Text = this.doc.DocumentTitle;
            }
            // If the document not new, and has been saved before
            else
            {
                using (Stream stream = new FileStream(this.doc.FilePath, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();

                    /******
                    //doc.Graph = this.Graph;

                    //doc.DocumentTitle = Path.GetFileName(dlg.FileName);
                    //doc.FilePath = dlg.FileName;
                    ******/

                        formatter.Serialize(stream, doc);
                }

                //this.Text = this.doc.DocumentTitle;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = ".drw";
                dlg.Filter = "Drawing files (*.drw)|*.drw";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                using (Stream stream =
                    new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();

                    /******
                    // Before serializing, set this app instance's document properties, then serialize
                    //doc.Graph = this.Graph;

                    //doc.DocumentTitle = Path.GetFileName(dlg.FileName);
                    //doc.FilePath = dlg.FileName;
                    ******/

                    formatter.Serialize(stream, this.doc);
                }
            }

            //this.Text = this.doc.DocumentTitle;
        }

        private void TopLevelForm_Load(object sender, EventArgs e)
        {
            ToolStripManager.Merge(BaseMenu, MainMenu);
            



        }

        private void InitializeSubmenuEvents()
        {


            menuOwners.Add(shapeToolStripMenuItem);
            menuOwners.Add(penToolStripMenuItem);
            menuOwners.Add(brushToolStripMenuItem);
            menuOwners.Add(ShapeToolStripDropDownButton);
            menuOwners.Add(BrushToolStripDropDownButton);
            menuOwners.Add(PenToolStripDropDownButton);
            menuOwners.Add(ColorToolStripDropDownButton);
            menuOwners.Add(colorToolStripMenuItem);




            foreach (ToolStripDropDownItem val in menuOwners)
            {
                foreach (ToolStripMenuItem sub in val.DropDownItems)
                {
                    sub.Click += ClickSubmenu;
                }
            }

        }

        private void ClickSubmenu(object sender, EventArgs e)
        {
            

            if (((ToolStripMenuItem)sender).Name.Contains("penColor"))
            {

                if (MainColorDialog.ShowDialog(this) == DialogResult.OK)
                {
                    SetBrushColor(MainColorDialog.Color);
                    //Changing label backcolor
                    if (this.MainColorDialog.Color.GetBrightness() < 0.5)
                    {
                        this.penColorLabel.ForeColor = Color.White;
                    }
                    else
                    {
                        this.penColorLabel.ForeColor = Color.Black;
                    }

                    this.penColorLabel.BackColor = MainColorDialog.Color;
                }

            }

            if (((ToolStripMenuItem)sender).Name.Contains("brushColor"))
            {
                if (MainColorDialog.ShowDialog(this) == DialogResult.OK)
                {
                    SetBrushColor(MainColorDialog.Color);
                    //Changing label backcolor
                    if (this.MainColorDialog.Color.GetBrightness() < 0.5)
                    {
                        this.brushColorLabel.ForeColor = Color.White;
                    }
                    else
                    {
                        this.brushColorLabel.ForeColor = Color.Black;
                    }

                    this.brushColorLabel.BackColor = MainColorDialog.Color;

                }

            }

            //Pen Types
            if (((ToolStripMenuItem)sender).Name.Contains("solidTool"))
            {
                    SetPen(0);
                this.penTypeLabel.Text = "Solid Pen";
            }

            if (((ToolStripMenuItem)sender).Name.Contains("customDashed"))
            {
                
                    SetPen(1);
                this.penTypeLabel.Text = "Custom Dash Pen";
            }

            if (((ToolStripMenuItem)sender).Name.Contains("compoundTool"))
            {

                SetPen(2);
                this.penTypeLabel.Text = "Compound Pen";
            }

            //Brush Types
            if (((ToolStripMenuItem)sender).Name.Contains("solidBrushTool"))
            {

                SetBrush(0);
                this.brushTypeLabel.Text = "Solid Brush";
            }

            if (((ToolStripMenuItem)sender).Name.Contains("hatchTool"))
            {

                SetBrush(1);
                this.brushTypeLabel.Text = "Hatch Brush";
            }

            if (((ToolStripMenuItem)sender).Name.Contains("linearGradientTool"))
            {

                SetBrush(2);
                this.brushTypeLabel.Text = "Linear Gradient Brush";
            }


            //SHAPES
          
            if (((ToolStripMenuItem)sender).Name.Contains("ellipse"))
            {

                SetShape(0);

            }

            if (((ToolStripMenuItem)sender).Name.Contains("rectangle"))
            {

                SetShape(1);

            }

            if (((ToolStripMenuItem)sender).Name.Contains("custom"))
            {

                SetShape(2);

            }
            
             if (((ToolStripMenuItem)sender).Name.Contains("curve"))
            {

                SetShape(3);

            }

            if (((ToolStripMenuItem)sender).Name.Contains("ellipse"))
            {

                SetShape(4);
                this.shapeTypeLabel.Text = "Ellipse";
            }

            if (((ToolStripMenuItem)sender).Name.Contains("lines"))
            {

                SetShape(5);

            }

            if (((ToolStripMenuItem)sender).Name.Contains("pie"))
            {

                SetShape(6);

            }

            if (((ToolStripMenuItem)sender).Name.Contains("polygon"))
            {

                SetShape(6);

            }

            if (((ToolStripMenuItem)sender).Name.Contains("rectangle"))
            {

                SetShape(7);
                this.shapeTypeLabel.Text = "Rectangle";
            }
            //if not color setting
            ResetSubmenus((ToolStripMenuItem)sender);
            //SubmenuAction(sender);
        }

      

        private void ResetSubmenus(ToolStripMenuItem menuItem)
        {
            foreach (ToolStripMenuItem val in menuItem.Owner.Items)
            {
                val.Checked = false;
            }
            menuItem.Checked = true;

        }

        private void SyncSubmenus()
        {
            //to be implemented
        }

        private void SubmenuAction(object sender)
        {
            int index = 0;
            foreach (ToolStripDropDownItem val in menuOwners)
            {
                for(int i = 0;  i< val.DropDownItems.Count; i++)
                {
                    if (val.DropDownItems[i].Equals(sender))
                    {

                        index = i;
                        return;
                    }
                }
            }

            switch (index)
            {
                case 0:

                    /*
                    ((Shape)(optionsForm.DataBindingSource.Current)).PenColor = Color.Red;
                    ((Shape)(optionsForm.DataBindingSource.Current)).BrushColor = Color.Black;
                    ((Shape)(optionsForm.DataBindingSource.Current)).PenType = PenTypeEnum.Solid;
                    ((Shape)(optionsForm.DataBindingSource.Current)).BrushType = BrushTypeEnum.Hatched;
                    ((Shape)(optionsForm.DataBindingSource.Current)).ShapeType = ShapeTypeEnum.Custom;
                    */
                    break;

                default:

                    break;
            }

        }

        private void SetPenColor(Color color)
        {
            ((Shape)(optionsForm.DataBindingSource.Current)).PenColor = color;

        }

        private void SetBrushColor(Color color)
        {
            ((Shape)(optionsForm.DataBindingSource.Current)).BrushColor = color;

        }

        private void SetPen(int index)
        {
            
            switch (index)
            {
                case 0: 
                    ((Shape)(optionsForm.DataBindingSource.Current)).PenType = Shape.PenTypeEnum.Solid;
                    break;
                case 1:
                    ((Shape)(optionsForm.DataBindingSource.Current)).PenType = Shape.PenTypeEnum.Dashed;
                    break;
                case 2:
                    ((Shape)(optionsForm.DataBindingSource.Current)).PenType = Shape.PenTypeEnum.Compound;
                    break;
                default:
                    break;

            }

        }

        private void SetBrush(int index)
        {

            switch (index)
            {
                case 0:
                    ((Shape)(optionsForm.DataBindingSource.Current)).BrushType = Shape.BrushTypeEnum.Solid;
                    break;
                case 1:
                    ((Shape)(optionsForm.DataBindingSource.Current)).BrushType = Shape.BrushTypeEnum.Hatched;
                    break;
                case 2:
                    ((Shape)(optionsForm.DataBindingSource.Current)).BrushType = Shape.BrushTypeEnum.LinearGradient;
                    break;
                default:
                    break;

            }
        }

        private void SetShape(int index)
        {

            switch (index)
            {
                case 0:
                    ((Shape)(optionsForm.DataBindingSource.Current)).ShapeType = Shape.ShapeTypeEnum.Ellipse;
                    break;
                case 1:
                    ((Shape)(optionsForm.DataBindingSource.Current)).ShapeType = Shape.ShapeTypeEnum.Rectangle;
                    break;
                case 2:
                    ((Shape)(optionsForm.DataBindingSource.Current)).ShapeType = Shape.ShapeTypeEnum.Custom;
                    break;
                default:
                    break;

            }

        }

        private void InitializeDS()
        {

            /* Take a look at code below to understand the data binding */
            var shape = new Shape();
            shape.LocationX = 300;
            shape.LocationY = 300;
            shape.SizeW = 100;
            shape.SizeH = 100;
            shape.PenColor = Color.Black;
            shape.PenType = PenTypeEnum.Dashed;
            shape.BrushColor = Color.Black;
            shape.BrushType = BrushTypeEnum.Solid;
            //var bs = new BindingSource();

            doc.addShape(shape);

            //var dg = new OptionsForm();
            this.optionsForm.DataBindingSource.DataSource = shape;
            //dg.DataBindingSource.DataSource = shape;
            //var result = this.optionsForm.ShowDialog();
            //result.Equals("AAAA");

        }


        /*
        private void TopLevelForm_DoubleClick(object sender, EventArgs e)
        {

            //testing event
            //doc.Draw(e.Graphics);
            //this.Invalidate();
            mainPictureBox.Invalidate();
        }



        /*
        /*
        private void PaintMeth(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 100;
            rect.Height = 100;
            e.Graphics.DrawRectangle(new Pen(Color.Red, 10),rect );
        }
        */

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((Shape)(optionsForm.DataBindingSource.Current)).LocationX = e.X;
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            xEndPoint = e.X;
            yEndPoint = e.Y;

            mainPictureBox.Invalidate();
        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            dc = e.Graphics;

            //float x = 
            
            //dc.CreateGra
            Rectangle rect = new Rectangle();
            rect.Width = Xthis;
            rect.Height = Ythis;
            dc.DrawRectangle(new Pen(Color.Red, 10), rect);

            Rectangle rect2 = new Rectangle();
            rect2.Width = Xthis + 200;
            rect2.Height = Ythis + 200;

            //mainPictureBox.Invalidate();
            //rect2.Location = new Point(300, 300);
            dc.DrawRectangle(new Pen(Color.Blue, 10), rect2);

            //doc.Draw(e.Graphics);


        }

        private void mainPictureBox_DoubleClick(object sender, EventArgs e)
        {
            Xthis += 100;
            Ythis += 100;

            this.mainPictureBox.Invalidate();

        }
    }

}
