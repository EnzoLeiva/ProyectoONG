using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IUnitOfWork
{
<<<<<<< HEAD

=======
>>>>>>> 6983bc6fb0c3b6134a8d30b850ad91a7c3a2c216
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<CategoryModel> CategoryRepository { get; }
        IBaseRepository<ContactsModel> ContactsRepository { get; }
        IBaseRepository<MemberModel> MemberRepository { get; }
        IBaseRepository<RoleModel> RoleRepository { get; }
        IBaseRepository<ActivitiesModel> ActivitiesRepository { get; }
        IBaseRepository<CommentModel> CommentRepository { get; }
        IBaseRepository<OrganizationModel> OrganizationRepository { get; }
        IBaseRepository<SlideModel> SlideRepository { get; }
        IBaseRepository<TestimonialsModel> TestimonialsRepository { get; }
        IBaseRepository<NewsModel> NewsRepository { get; }
        IBaseRepository<UserModel> UserRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
