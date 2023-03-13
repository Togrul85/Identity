using Microsoft.AspNetCore.Identity;

namespace FrontToBack2.Models
{
    public class AppUser:IdentityUser
    {
        public string  Fullname { get; set; }
        
    }
}
