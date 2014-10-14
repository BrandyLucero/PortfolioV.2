using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//set up data annotationd
using System.ComponentModel.DataAnnotations;


namespace Portfolio.Models
{
    //set up meta type for annotations regarding this class
    [MetadataType(typeof(ContactsValidation))]
    //create a public class for where we are linking to 
    public class Contacts
    {

    }
    public class ContactsValidation
    {
        //all properties are required 
        [Required, Display(Name = "Name")]
        public string Name { get; set; }

        [Required, EmailAddress, Display(Name = "Email")]
        public string Email { get; set; }

        [Required, Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(500), Display(Name = "Comments")]
        public string Comment { get; set; }
    }
}