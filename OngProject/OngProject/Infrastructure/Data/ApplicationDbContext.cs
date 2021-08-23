using Microsoft.EntityFrameworkCore;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OngProject.Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>()
                .HasIndex(u => u.email)
                .IsUnique();

            base.OnModelCreating(builder);
            this.SeedActivities(builder);
            this.SeedRoles(builder);
            this.SeedUsers(builder);

            
        }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<OrganizationModel> Organizations { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<SlideModel> Slides { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ContactsModel> Contacts { get; set; }
        public DbSet<ActivitiesModel> Activities { get; set; }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<TestimonialsModel> Testimonials { get; set; }

        private void SeedActivities(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<ActivitiesModel>().HasData(
                    new ActivitiesModel
                    {
                        Id = i,
                        Name = "Activity " + i,
                        Image = "ImageActivities" + i + ".jpg",
                        Content = "Content from activity " + i,
                        CreatedAt = DateTime.Now
                    }
                );
            }
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 3; i++)
            {
                modelBuilder.Entity<RoleModel>().HasData(
                    new RoleModel
                    {
                        Id = i,
                        Name = i == 1 ? "Admin" : "Standard",
                        Description = i == 1 ? "Admin User" : "Standard User",
                        IsDeleted = false,
                        CreatedAt = DateTime.Now
                    }
                );
            }
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 21; i++)
            {
                modelBuilder.Entity<UserModel>().HasData(
                    new UserModel
                    {
                        Id = i,
                        firstName = "User " + i,
                        lastName = i < 11 ? "AdminUser " + i : "RegularUser " + i,
                        email = "mail" + i + "@Mail.com",
                        password = i < 11 ? UserModel.ComputeSha256Hash("Admin123") : UserModel.ComputeSha256Hash("User123"),
                        photo = "TestUsers" + i + ".jpg",
                        roleId = i < 11 ? 1 : 2,
                        CreatedAt = DateTime.Now,
                        IsDeleted = false
                    }
                );
            }
        }



      
    }
}
