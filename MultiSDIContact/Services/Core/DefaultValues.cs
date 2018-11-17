using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIContact.Services.Core
{
    class DefaultValues
    {
        /// <summary>
        /// The default first name used when creating a new contact
        /// </summary>
        public static string FirstName
        {
            get { return Properties.Settings.Default.DefaultFirstName; }
            set
            {
                Properties.Settings.Default.DefaultFirstName = value;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// The default last name used when creating a new contact
        /// </summary>
        public static string LastName
        {
            get { return Properties.Settings.Default.DefaultLastName; }
            set
            {
                Properties.Settings.Default.DefaultLastName = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
