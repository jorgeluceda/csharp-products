using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MultiSDIText.Storage
{
    [Serializable]
    public class Document: ISerializable
    {
        #region Constructor

        /// <summary>
        /// Simple constructor that initilaizes all properties
        /// </summary>
        public Document(BindingList<Text> list)
        {
            this.content = list;
        }

        public Document(String s)
        {
            this.content = TurnIntoTextObjects(s);
        }

        /// <summary>
        /// Simple constructor that initilaizes all properties
        /// </summary>
        public Document() : this(new BindingList<Text>())
        {
            
        }

        #endregion

        #region Content

        /// <summary>
        /// The content of the document. A list of texts sorted by z-order
        /// </summary>
        public BindingList<Text> content;

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
            content.OrderBy(x => x.ZOrder);
            content.Reverse();
        }

        #endregion

        #region ISerializable

        /// <summary>
        /// Desirializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected Document(SerializationInfo info, StreamingContext context)
        {
            this.content = (BindingList<Text>) info.GetValue("content", typeof(BindingList<Text>));
        }

        /// <summary>
        /// Serializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("content", this.content, typeof(List<Text>));
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

        /// <summary>
        /// Finds if a point belongs to any of the texts
        /// in the document
        /// </summary>
        /// <param name="p">The point to be found</param>
        /// <returns>The text that was hit by the point or null</returns>
        public Text Find(Point p)
        {
            foreach (Text t in this.content)
            {
                if (t.PointWithinBoundaries(p))
                    return t;
            }

            return null;
        }

        /// <summary>
        /// Gets a string and returns an array of Text object representing each word.
        /// </summary>
        /// <param name="p">The string to split into words</param>
        /// <returns>An array of words as Text object</returns>
        public BindingList<Text> TurnIntoTextObjects(String s)
        {
            String[] words = Regex.Split(s, "\\s+");
            BindingList<Text> texts = new BindingList<Text>();

            int locationx = 50;
            int locationy = 50;
            for (int i = 0; i < words.Length; i++)
            {
                Text text = new Text();
                text.Content = words[i];
                text.Location = new Point(locationx, locationy);
                locationx += 30;
                locationy += 30;
                texts.Add(text);
            }
            return texts;
        }

        #endregion
    }
}
