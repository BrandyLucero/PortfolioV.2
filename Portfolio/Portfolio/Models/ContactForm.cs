
namespace Portfolio.Models
{
    using System;
    using System.Collections.Generic;

    public partial class ContactForm
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber{get; set;}
        public string Comments { get; set; }
    }
}