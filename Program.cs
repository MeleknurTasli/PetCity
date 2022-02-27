using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IAccountService,AccountService>();
var app = builder.Build();
  using (var context = new LibraryContext()) {
        context.Database.EnsureCreated();
    }

    using(var context = new PetCityContext())
    {  
        if(context.Database.EnsureCreated())
        {
        var databaseCreator = context.Database.GetService<IServiceProvider>().GetService<IRelationalDatabaseCreator>();
        if(databaseCreator is not null)
        databaseCreator.CreateTables();
        }
    }

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

