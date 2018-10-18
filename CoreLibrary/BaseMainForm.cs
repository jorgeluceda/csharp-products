using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreLibrary
{
    public partial class BaseMainForm : Form
    {
        public BaseMainForm()
        {
            InitializeComponent();
            //InitializeSubmenuEvents();
        }

        virtual public void smiOath_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("The Oath menu item is not implemented");
        }

        private void smiAbout_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("The About menu item is not implemented");
        }

        /*
        private void InitializeSubmenuEvents()
        {

            List<ToolStripDropDownItem> menuOwners = new List<ToolStripDropDownItem>();

            menuOwners.Add(shapeToolStripMenuItem);
            menuOwners.Add(penToolStripMenuItem);
            menuOwners.Add(brushToolStripMenuItem);

            menuOwners.Add(ShapeToolStripDropDownButton);
            menuOwners.Add(BrushToolStripDropDownButton);
            menuOwners.Add(PenToolStripDropDownButton);



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
            ResetSubmenus((ToolStripMenuItem)sender);
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

        }

    */


    }

}
