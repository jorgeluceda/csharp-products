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
        public Document(List<Text> list)
        {
            this.content = list;
        }

        /// <summary>
        /// Simple constructor that initilaizes all properties
        /// </summary>
        public Document() : this(new List<Text>())
        {
            
        }

        #endregion

        #region Content

        /// <summary>
        /// The content of the document. A list of texts sorted by z-order
        /// </summary>
        private List<Text> content;

        public void Add(Text text)
        {
            this.content.Add(text);
        }

        #endregion

        #region Functionality

        /// <summary>
        /// Draw the content of the document
        /// </summary>
        /// <param name="g">Graphics used to draw</param>
        public void Draw(Graphics g)
        {
            foreach(Text t in this.content)
            {
                t.Draw(g);
            }
        }

        #endregion
    }
}
