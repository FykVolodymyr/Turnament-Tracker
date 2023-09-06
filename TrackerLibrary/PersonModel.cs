using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents person first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents persons last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents persons contact email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents persons phone number for contacting 
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
