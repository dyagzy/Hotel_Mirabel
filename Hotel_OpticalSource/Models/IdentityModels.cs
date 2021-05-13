using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Hotel_OpticalSource.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string Name { get; set; }

        public string Address { get; set; }
        public bool IsActive { get; set; }
        public DateTime Date { get; set; }


        //[NotMapped]
        /*returns a list of all the guest*/

        // public virtual List<Guest> Guests => new ApplicationDbContext().Guests.ToList();
        public virtual List<Room_Usage> Room_Usages =>
            new ApplicationDbContext().Room_Usage.ToList().ToList().Where(x => x.Guest_Id == Id).ToList();






    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Hotel_OpticalSource.Models.Guest> Guests { get; set; }

        public System.Data.Entity.DbSet<Hotel_OpticalSource.Models.Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<Hotel_OpticalSource.Models.Room_Usage> Room_Usage { get; set; }
    }
}