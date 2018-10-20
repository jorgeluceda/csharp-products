using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.Content = new Container();
        }

        #endregion

        #region Content

        /// <summary>
        /// Holds a list of all the text objects
        /// </summary>
        private Container Content { get; set; }

        #endregion

        #region Functionality

        // Region where all the documents actions are going to be performed

        #endregion
    }
}
