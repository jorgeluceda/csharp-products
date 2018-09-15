using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreLibrary
{
    public partial class CourseDescription : UserControl
    {
        public CourseDescription()
        {
            InitializeComponent();
        }

        private void CourseDescription_Load(object sender, EventArgs e)
        {
            if (this.Parent == null)
                return;

            this.BackColor = this.Parent.BackColor;
            this.lblCourseName.ForeColor = this.Parent.ForeColor;
            this.lblSemesterName.ForeColor = this.Parent.ForeColor;
        }
    }
}
