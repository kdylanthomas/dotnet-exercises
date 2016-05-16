using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
<<<<<<< HEAD
using BangazonMVC.Models;
=======
>>>>>>> e619d885fb72112c24f643800ea52f691927b137

namespace BangazonMVC.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
<<<<<<< HEAD
        public DbSet<Customer> Customer { get; set; }
=======
>>>>>>> e619d885fb72112c24f643800ea52f691927b137
    }
}
