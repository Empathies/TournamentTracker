using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Defines the first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Defines the last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Defines the Email Address of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Defines the phone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
