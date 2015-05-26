using Microsoft.AspNet.Identity.EntityFramework;

namespace K_Mug
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}