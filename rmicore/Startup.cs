using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using rmicore.Helpers;
using rmicore.Services;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using rmicore;
using Microsoft.AspNetCore.Mvc;
using rmicore.Interface;
using rmicore.Repository;

namespace rmicore
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
          
            services.AddMvc(option => option.EnableEndpointRouting = false);


            //services.AddCors();
            services.AddDbContext<RepositoryContext>(
             options => options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));
          
              services.AddMvc();
              services.AddAutoMapper(typeof(Startup));

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
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

            // configure DI for application services
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IDataRepository, DataRepository>();
            services.AddScoped<IDataService, DataService>();
            services.AddScoped<IRiderService, RiderService>();
            services.AddScoped<IRiderRepository, RiderRepository>();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                    builder.SetIsOriginAllowed(_ => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();


            app.UseCors();
      

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}



//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using rmicore.Entities;
//using rmicore.Repository;
//using AutoMapper;
//using rmicore.Interface;
//using rmicore.Services;
//using Microsoft.AspNetCore.Identity;
//using rmicore.Helpers;
//using System.Text;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.IdentityModel.Tokens;

//namespace rmicore
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {


//            // configure strongly typed settings objects
//            var appSettingsSection = Configuration.GetSection("AppSettings");
//            services.Configure<AppSettings>(appSettingsSection);

//            // configure jwt authentication
//            var appSettings = appSettingsSection.Get<AppSettings>();
//            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
//            services.AddAuthentication(x =>
//            {
//                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//            })
//            .AddJwtBearer(x =>
//            {
//                x.RequireHttpsMetadata = false;
//                x.SaveToken = true;
//                x.TokenValidationParameters = new TokenValidationParameters
//                {
//                    ValidateIssuerSigningKey = true,
//                    IssuerSigningKey = new SymmetricSecurityKey(key),
//                    ValidateIssuer = false,
//                    ValidateAudience = false
//                };
//            });

//            //Add MVC Middleware  
//            services.AddControllersWithViews();

//            services.AddDbContext<RepositoryContext>(
//               options => options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));


//            //Configure Identity
//            services.AddIdentity<Client, IdentityRole>().AddEntityFrameworkStores<RepositoryContext>();

//            //IOC      
//            services.AddScoped<IDataRepository, DataRepository>();
//            services.AddScoped<IDataService, DataService>();
//            services.AddScoped<IUserService, UserService>();
//            //

//            //Mapper
//            services.AddAutoMapper(typeof(Startup));



//            services.AddCors(o => o.AddPolicy("ReactPolicy", builder =>
//            {
//                builder.AllowAnyOrigin()
//                       .AllowAnyMethod()
//                       .AllowAnyHeader();

//            }));
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }

//            app.UseHttpsRedirection();



//            app.UseRouting();

//            app.UseCors("ReactPolicy");

//            app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });


//        }
//    }
//}
