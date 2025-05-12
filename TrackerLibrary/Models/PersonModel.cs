using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {


        /// <summary>
        /// Unique Id for all Person.
        /// </summary
        public int Id { get; internal set; }

        /// <summary>
        /// Represents first name of the person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents last name of the preson.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represnets email address of the person.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents cell phone number of person.
        /// </summary>
        public string CellphoneNumber { get; set; }


        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }


    }
}
