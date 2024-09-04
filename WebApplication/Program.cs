using PT_SIxDegrees.Api.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using PT_SIxDegrees.Api.Business.Service;
using PT_SIxDegrees.Api.DataAccess.UsuarioConfig.Contract;
using PT_SIxDegrees.Api.DataAccess.UsuarioConfig.Implementation;

namespace PT_SIxDegrees.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var NewPolice = "_NewPolice";

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: NewPolice, app =>
                {
                    app.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<UsuarioDbContext>(o =>
            {
                o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddScoped<IUsuarioConfiguration, UsuarioConfiguration>();
            builder.Services.AddScoped<UsuarioConfigurationBusiness>();

            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(NewPolice);

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            

            app.Run();
        }
    }
}