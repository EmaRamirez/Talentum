using Microsoft.EntityFrameworkCore;
using talentum.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("TalemtumDb") ?? throw new InvalidOperationException("Connection string  'TalemtumDb' not found");
builder.Services.AddDbContext<Context>(option => option.UseSqlServer(connectionString));
var app = builder.Build();




// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
