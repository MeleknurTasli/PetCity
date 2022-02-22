var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountService,AccountService>();//Bu işlemden sonra AccountService yerine IAccountService kullnılacak.
<<<<<<< HEAD
builder.Services.AddScoped<IProductService,ProductService>();
=======
builder.Services.AddScoped<PetHelperValidator>();
builder.Services.AddScoped<IPetHelperService,PetHelperService>();
builder.Services.AddScoped<IPetService,PetService>();
>>>>>>> dev/main
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

