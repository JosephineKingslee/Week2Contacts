using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Models
{
    public class Contact
    {
        //EF Core will configure the database to generate this value
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [RegularExpression("^[a-zA-Z_ ]*$", ErrorMessage = "Numerics Not allowed")]
        public string Name { get; set; }

        [RegularExpression("^[0-9_ ]*$", ErrorMessage = "Phone Number must be numeric")]
        [Required(ErrorMessage = "Please enter a phone number.")]
        public long? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a note.")]
        [RegularExpression("^[a-zA-Z0-9_ ]*$", ErrorMessage = "Special Characters Not allowed")]
        public string Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + PhoneNumber?.ToString();

    }
}