using ProductsAPIService.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//fetching the connection string from file
//string? conStr = builder.Configuration.GetConnectionString("EpsilonDbConStr");

//Part-1: service registration

// Add services to the container for Web API application
builder.Services.AddControllers();
builder.Services.AddScoped<IRepository, ProductRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Part-2: host creation
WebApplication app = builder.Build();


//use middlewares

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
