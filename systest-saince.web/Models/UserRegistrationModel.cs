using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Systemtest_saince.Models
{
    public class UserRegistrationModel
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required]
        public int MobileNumber { get; set; }
        [Required]
        public string Email { get; set; }

       public List<Address> Addresses { get; set; } 

    }

    public class Address
    {

        [Required]
        public string Address1 { get; set; }

        [Required]

        public SelectListItem City { get; set; }

        [Required]

        public SelectListItem State { get; set; }


        [Required]
        public string LandMark { get; set; }

        [Required]
        public int Zipcode { get; set; }
    }
}
