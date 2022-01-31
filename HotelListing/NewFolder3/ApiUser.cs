using Microsoft.AspNetCore.Identity;

namespace HotelListing.NewFolder3
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
