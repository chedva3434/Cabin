using Clean.Core.Repositores;
using Clean.Core.Service;
using Clean.Data;
using Clean.Data.Repositores;
using ManagementCabin;
using ManagementCabin.Core;
using ManagementCabin.Core.Repositores;
using ManagementCabin.Data.Repositores;
using ManagementCabin.Service;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICabinService,CabinService>();
builder.Services.AddScoped<ICabinRepositores, CabinRepositores>();

builder.Services.AddScoped<ICastomerService,CastomerService>();
builder.Services.AddScoped<ICastomerRepositores, CastomerRepositores>();

builder.Services.AddScoped<IOrderService,OrderService>();
builder.Services.AddScoped<IOrderRepositores,OrderRepositores>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseTrack();

app.MapControllers();

app.Run();
