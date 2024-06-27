using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApiGroupProject.Data;
namespace ApiGroupProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<GroupDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("GroupDbContext") ?? throw new InvalidOperationException("Connection string 'GroupDbContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors();

            var app = builder.Build();

           // app.UseCors();--needs the add 

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
