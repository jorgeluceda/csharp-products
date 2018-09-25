using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    interface ITeam3Interface
    {
        int ShapeWidth
        { get; set; }

        int ShapeHeight
        { get; set; }

        float ShapeRatio
        { get; set; }

        event EventHandler Apply;
    }
}
