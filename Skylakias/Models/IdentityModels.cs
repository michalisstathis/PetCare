using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Skylakias.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public virtual MembershipType MembershipType { get; set; }

        [ForeignKey("MembershipType")]
        public int MembershipTypeId { get; set; }
        public DateTime? Birthdate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        
        public virtual DbSet<MembershipType> MembershipTypes { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //protected override void OnModelCreating(DbModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    // Primary keys
        //    builder.Entity<Customer>().HasKey(q => q.Id);
        //    builder.Entity<Service>().HasKey(q => q.Id);
        //    builder.Entity<Order>().HasKey(q =>
        //    new
        //    {
        //        q.CustomerId,
        //        q.ServiceId
        //    });



        //    // Relationships
        //    builder.Entity<Order>()
        //    .HasRequired(q => q.Customer)
        //    .WithMany(q => q.Orders)
        //    .HasForeignKey(q => q.CustomerId);

        //    builder.Entity<Order>()
        //    .HasRequired(q => q.Service)
        //    .WithMany(q => q.Orders)
        //    .HasForeignKey(q => q.ServiceId);







        //}
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        
    }
}