using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*


Save Size button: set the user setting for the size to the current client size and save the settings. 
    Anchor the button to the lower left corner of the group box.
Save Location button: set the user setting for the location to the current desktop location and save the settings. 
    Anchor the button to thelower right corner of the group box.
Reset Settings button: reset the user settings to the original default values. 
    Set the client size and desktop location to the reset settings. 
    Anchor the button to the bottom edge of the group box. 
     
     
*/

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
