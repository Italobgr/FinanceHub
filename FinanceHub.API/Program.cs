using FinanceHub.Infrastucture;
using FinanceHub.Infrastucture.Data; 
using Microsoft.EntityFrameworkCore;
//using FinanceHub.API.Controllers;


var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// connection
builder.Services.AddDbContext<FinanceHubContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


//aqui

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


