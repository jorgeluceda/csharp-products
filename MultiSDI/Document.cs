using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MultiSDI
{
    /* This Class will store our shapes */
    class Document
    { 
        public List<Shape> shapes = new List<Shape>();

        public void Draw(Graphics graphics)
        {
            foreach(Shape shape in shapes)
            {
                shape.Draw(graphics);
            }
        }

        public void addShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void removeShape(Shape shape)
        {
            shapes.Remove(shape);
        }
    }
}
