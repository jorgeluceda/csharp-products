using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDI
{
    /* This Class will store our shapes */
    class Document
    { 
        List<Shape> shapes = new List<Shape>();

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
