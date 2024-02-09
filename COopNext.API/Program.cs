using COopNext.Application.Interfaces;
using COopNext.Application.Services;
using COopNext.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add your DbContext for dependency injection
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Configure your database connection string and other options here
    options.UseSqlServer(builder.Configuration.GetConnectionString("YourConnectionString"));
});

// Add your services for dependency injection here
builder.Services.AddTransient<IModuleService, ModuleService>();

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