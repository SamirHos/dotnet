using Microsoft.EntityFrameworkCore;
using WebApiProvaFinaleBSamir.DataSource;
using WebApiProvaFinaleBSamir.Repository;
using WebApiProvaFinaleBSamir.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LogContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("cnPostgres")));

builder.Services.AddScoped<LogContext, LogContext>();
builder.Services.AddScoped<ILogRepository, LogRepository>();
builder.Services.AddScoped<IProdottiService, ProdottiService>();


//CORS
var myPolicy = "myPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myPolicy, policy =>
    {
        policy.WithOrigins("http://192.168.1.50");
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(myPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
