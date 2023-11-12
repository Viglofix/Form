using DataBase;
using Services.Service;
using Services.Container;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Services.Helper;

namespace FormAPI;
    public class Program
    {
        // test
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

            // DbContext -- Section
            builder.Services.AddDbContext<FormDbContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("FormDb")));
            // Services -- Section
            builder.Services.AddTransient<IClickUpService,ClickUpService>();
            builder.Services.AddTransient<IFileManagementService,FileManagementService>();
            //Authentication
            builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            var app = builder.Build();
            app.UseCors("UniversalPolicy");

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
