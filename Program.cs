using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<Program>();
            }).ConfigureApiBehaviorOptions(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    return new CustomBadRequest(context);
                };
            });
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PetCityContext>();

builder.Services.AddScoped<IIncidenceRepository,IncidenceRepository>();
builder.Services.AddScoped<ISupplierRepository,SupplierRepository>();
builder.Services.AddScoped<ISupplierService,SupplierService>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ILoginService, LoginService>();


builder.Services.AddScoped<PetCityContext>();
// builder.Services.AddScoped<IAccountService,AccountService>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
      .AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader());
app.UseMiddleware<JwtMiddleware>();


//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


