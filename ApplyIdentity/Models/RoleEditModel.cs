using System.Collections.Generic;
using ApplyIdentity.Infrastructure;

namespace ApplyIdentity.Models
{
    public class RoleEditModel
    {
        public AppRole Role { get; set; }

        public IEnumerable<AppUser> Members { get; set; }

        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}