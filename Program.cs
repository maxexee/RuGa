using Microsoft.EntityFrameworkCore;
using RuGa.Data.DataBases;

namespace RuGa;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // =============================================================================================
        // ======================================== DBCONTEXT ==========================================
        var conn    =   builder.Configuration.GetConnectionString("PostrgresqlConnection");
        builder.Services.AddDbContext<ApiDbContext>(options =>  options.UseNpgsql(conn));

        // =============================================================================================
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
