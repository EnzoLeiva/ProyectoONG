using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Services;
using OngProject.Infrastructure;
using OngProject.Infrastructure.Data;
using OngProject.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Interfaces.IServices;
using System.Text;
using Amazon.S3;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using OngProject.Core.Services.Auth;

namespace OngProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddTransient<IMemberService, MemberService>();

            services.AddControllers();

            var key = Encoding.ASCII.GetBytes(Configuration["JWT:Secret"]);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OngProject", Version = "v1" });
            });

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IActivitiesService, ActivitiesService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IOrganizationService, OrganizationService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IContactsService, ContactsService>();
            services.AddTransient<INewsService, NewsService>();
            services.AddTransient<ISlideService, SlideService>();
            services.AddTransient<ITestimonialsService, TestimonialsService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddAWSService<IAmazonS3>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OngProject v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
