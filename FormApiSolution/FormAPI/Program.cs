using DataBase;
using Services.Service;
using Services.Container;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using FormAPI.AuthenticationHelper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AutoMapper;
using DataBase.Model;

namespace FormAPI;
    public class Program
    {
        // Do zrobienia -- ToString do Modeli z uzyciem slowa kluczowego Partial.
        // Do zrobienia -- Dynamiczna walidacja uzytkownika, jesli takowy istnieje w bazie danych.
        // W momencie gdy po froncie uzytkownik dodaje imie i nazwisko
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // CORS Policy Section
            builder.Services.AddCors(optPolicy =>
            {
                optPolicy.AddPolicy("UniversalPolicy", optConfig =>
                {
                    optConfig.WithOrigins("*");
                    optConfig.AllowAnyMethod();
                    optConfig.AllowAnyHeader();
                });
            });

           var jwtOptions = builder.Configuration
           .GetSection("JwtOptions")
           .Get<JwtOptions>();

            builder.Services.AddRateLimiter(options =>
            {
                options.AddFixedWindowLimiter("fixed",opt =>
                {
                    opt.PermitLimit = 1;
                    opt.Window = TimeSpan.FromSeconds(5);
                    opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                    opt.QueueLimit = 2;
                });
            });

            // DbContext -- Section
            builder.Services.AddDbContext<FormDbContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("FormDb")));
            // Services -- Section
            builder.Services.AddTransient<IClickUpService,ClickUpService>();
            builder.Services.AddTransient<IFileManagementService,FileManagementService>();
            builder.Services.AddTransient<IQuizService, QuizService>();

            var mapperConfig = new MapperConfiguration(cfg => {
               cfg.CreateMap<ClickUpRequiredDataModelRequest,ClickUpRequiredDataModel>();
            });

            IMapper mapper = mapperConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);
            //Authentication
            //  builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
           
            /* builder.Services.AddSingleton(jwtOptions);

             builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(opt=>{
               byte[] signingKeyBytes = Encoding.UTF8
               .GetBytes(jwtOptions.SigningKey);

            opt.TokenValidationParameters = new TokenValidationParameters
               {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtOptions.Issuer,
            ValidAudience = jwtOptions.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
             };
            });
            
            builder.Services.AddAuthorization(); */

            var app = builder.Build();
            app.UseCors("UniversalPolicy");
            app.UseRateLimiter();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication(); 
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
