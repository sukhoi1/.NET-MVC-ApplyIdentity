using Microsoft.AspNet.Identity.EntityFramework;

namespace ApplyIdentity.Infrastructure
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base()
        {
        }

        public AppRole(string name) : base(name)
        {
        }
    }
}