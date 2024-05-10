using Microsoft.EntityFrameworkCore;
using TrainBooking.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

string conn = "Data Source=LAPTOP-IGRCM4GB\\SHENARI;Initial Catalog=Shenari57;User ID=sa;Password=sql345;Connect Timeout=30;Encrypt=False;TrustServerCertificate=Yes;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<TrainRepository>();
builder.Services.AddScoped<SeatBookingRepository>();
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(conn));

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
