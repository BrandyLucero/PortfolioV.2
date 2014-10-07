using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//set up data annotations 
using System.ComponentModel.DataAnnotations;


namespace Portfolio.Models
{
    
        //set up meta type for anotatios regarding this class
        [MetadataType(typeof(ContactValidaion))]
        //create a public partial class for where we are linking to 
        public partial class Contact
        {

        }
        public class ContactValidaion
        {
            //all properties are required
            [Required, Display(Name="First Name")]
            public string FirstName {get;set;}

            [Required, Display(Name="Last Name")]
            public string LastName { get; set;}

            [Required, EmailAddress, Display(Name="Email")]
            public string EmailAddress {get; set;}

            [Required, Phone, Display(Name="Phone #")]
            public string ContactNumber {get; set;}

            [Required, MaxLength(200)]
            public string Comment { get; set;}
        }
    }
