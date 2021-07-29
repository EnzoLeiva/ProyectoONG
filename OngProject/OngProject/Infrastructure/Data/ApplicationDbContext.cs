using Microsoft.EntityFrameworkCore;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.Models;

namespace OngProject.Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>()
                .HasIndex(u => u.email)
                .IsUnique();
        }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<OrganizationModel> Organizations { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<SlideModel> Slides { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ContactsModel> Contacts { get; set; }
        public DbSet<ActivitiesModel> Activities { get; set; }
        public DbSet<MembersModel> Member { get; set; }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<TestimonialsModel> Testimonials { get; set; }

    }
}
