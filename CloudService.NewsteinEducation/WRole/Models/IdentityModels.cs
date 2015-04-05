using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WRole.Models
{
    // You can add profile data for the user by adding more properties to your IdentityUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    //public class IdentityUser : IdentityUser
    //{
    //}

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        //public System.Data.Entity.DbSet<WRole.Models.Group.Group> Groups { get; set; }

        //public System.Data.Entity.DbSet<WRole.Models.IdentityUser> IdentityUsers { get; set; }

    }
}