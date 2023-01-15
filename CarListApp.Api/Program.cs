using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CarListApp.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            });

            var dbPath = Path.Join(Directory.GetCurrentDirectory(), "carlist.db");
            var connection = new SqliteConnection($"Data Source={dbPath}");
            builder.Services.AddDbContext<CarListDbContext>(c => c.UseSqlite(connection));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");

            app.UseAuthorization();

            app.MapGet("/cars", async (CarListDbContext db) => await db.Cars.ToListAsync());

            app.MapGet("/cars/{id}", async (int id, CarListDbContext db) =>
            {
                return await db.Cars.FindAsync(id) is Car car ? Results.Ok(car) : Results.NotFound();
            });

            app.MapPost("/cars", async (Car car, CarListDbContext db) =>
            {
                await db.Cars.AddAsync(car);
                await db.SaveChangesAsync();

                return Results.Created($"/cars/{car.Id}", car);
            });
            
            app.MapPut("/cars/{id}", async (int id, Car car, CarListDbContext db) =>
            {
                var record = await db.Cars.FindAsync(id);
                if (record is null) return Results.NotFound();

                record.Brand = car.Brand;
                record.Model = car.Model;
                record.Year = car.Year;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });
            
            app.MapDelete("/cars/{id}", async (int id, CarListDbContext db) =>
            {
                var record = await db.Cars.FindAsync(id);
                if (record is null) return Results.NotFound();

                db.Remove(record);
                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            app.Run();
        }
    }
}