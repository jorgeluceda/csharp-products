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

        /// <summary>
        /// Helper method to add a text to the content, in a sorted manner
        /// </summary>
        /// <param name="text">The text to be added</param>
        public void Add(Text text)
        {
            this.content.Add(text);

            if (this.content.Count > 0)
                this.SortContentByZOrder();
        }

        /// <summary>
        /// Remove the first occurrence of a text
        /// </summary>
        /// <param name="text">The text to be removed</param>
        /// <returns>Whether or not the text was removed successfully</returns>
        public bool Delete(Text text)
        {
            return this.content.Remove(text);
        }

        /// <summary>
        /// Remove element at index specified
        /// </summary>
        /// <param name="index">The index to be removed</param>
        public void DeleteAt(int index)
        {
            this.content.RemoveAt(index);
        }

        /// <summary>
        /// Helper method to sort the content by ZOrder
        /// </summary>
        private void SortContentByZOrder()
        {
            this.content.Sort(delegate (Text x, Text y)
            {
                return y.ZOrder.CompareTo(x.ZOrder);
            });
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
