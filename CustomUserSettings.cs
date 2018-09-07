using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class CustomUserSettings
    {
        public static int MainFormClientSizeWidth
        {
            get
            {
                return Properties.Settings.Default.MainFormClientSizeWidth;
            }
            set
            {
                Properties.Settings.Default.MainFormClientSizeWidth = value;
            }
        }

        public static int MainFormClientSizeHeight
        {
            get
            {
                return Properties.Settings.Default.MainFormClientSizeHeight;
            }
            set
            {
                Properties.Settings.Default.MainFormClientSizeHeight = value;
            }
        }

        public static int MainFormLocationX
        {
            get
            {
                return Properties.Settings.Default.MainFormLocationX;
            }
            set
            {
                Properties.Settings.Default.MainFormLocationX = value;
            }
        }

        public static int MainFormLocationY
        {
            get
            {
                return Properties.Settings.Default.MainFormLocationY;
            }
            set
            {
                Properties.Settings.Default.MainFormLocationY = value;
            }
        }
    }
}
