using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.User
{
    public class UserServiceModel
    {
        [Display(Name = "E-Mail")]
        public string EMail { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        public decimal Balance { get; set; }
    }
}
