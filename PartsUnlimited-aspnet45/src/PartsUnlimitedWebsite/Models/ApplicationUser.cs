using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        // My First Change 
        public string Name { get; set; }
    }
}
