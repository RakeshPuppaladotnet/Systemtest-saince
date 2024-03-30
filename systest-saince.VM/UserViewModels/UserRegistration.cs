using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace systest_saince.api.ViewModels
{
    public class UserRegistration
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required]
        public int MobileNumber { get; set; }
        [Required]
        public string Email { get; set; }

       public List<Address> Address { get; set; }
    }

    public class Address {
        [Required]
        public string Address1 { get; set; }

        [Required]

        public string City { get; set; }

        [Required]

        public string State { get; set; }


        [Required]
        public string LandMark { get; set; }

        [Required]
        public int Zipcode { get; set; }
    }
}
