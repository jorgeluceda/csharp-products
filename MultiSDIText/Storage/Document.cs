using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIText.Storage
{
    public class Document
    {
        #region Constructor

        /// <summary>
        /// Simple constructor that initilaizes all properties
        /// </summary>
        public Document()
        {
            this.Content = new List<Text>();
        }

        #endregion

        #region Content

        /// <summary>
        /// Holds a list of all the text objects
        /// </summary>
        private List<Text> Content { get; set; }

        #endregion

        #region Functionality

        /// <summary>
        /// Draw the content of the document
        /// </summary>
        /// <param name="g">Graphics used to draw</param>
        public void Draw(Graphics g)
        {
            foreach(Text t in this.Content)
            {
                t.Draw(g);
            }
        }

        #endregion
    }
}
