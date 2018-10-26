using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIText.Storage
{
    [Serializable]
    public class Document: ISerializable
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

        #region ISerializable

        /// <summary>
        /// Desirializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected Document(SerializationInfo info, StreamingContext context)
        {
            this.content = (List<Text>) info.GetValue("content", typeof(List<Text>));
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
        public Text[] Split(String s)
        {
            String[] words = s.Split(' ');
            Text[] texts = new Text[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                texts[i] = new Text();
                texts[i].Content = words[i];
            }
            return texts;
        }

        #endregion
    }
}
