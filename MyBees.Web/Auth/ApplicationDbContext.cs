using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyBees.Web.Auth {
    public class ApplicationDbContext : IdentityDbContext<AppUser> {
        public ApplicationDbContext (DbContextOptions options) : base (options) { }
    }
}