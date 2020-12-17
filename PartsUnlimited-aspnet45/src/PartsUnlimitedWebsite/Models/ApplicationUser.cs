using Microsoft.AspNet.Identity.EntityFramework;
//6th chnages
namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
