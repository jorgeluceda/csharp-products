using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIContact.Services.Entities
{
    abstract public class BaseEntity : INotifyPropertyChanged
    {
        #region DataBinding

        /// <summary>
        /// The property change handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fires the property change event for a property
        /// </summary>
        /// <param name="propertyName">The property name that changed</param>
        protected void PropertyChange(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
