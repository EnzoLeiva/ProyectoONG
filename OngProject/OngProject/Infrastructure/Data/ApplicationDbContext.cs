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

        public DbSet<MemberModel> Members { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ContactsModel> Contacts { get; set; }
        public DbSet<ActivitiesModel> Activities { get; set; }

    }
}
