using Kontas.API.AutoMapper;
using Kontas.API.Entities;
using Kontas.API.Repositories;
using Kontas.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddDbContext<KontasDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("KontasDB"));
});

//injection
builder.Services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddTransient<IContaRepository, ContaRepository>();
builder.Services.AddTransient<IContaPagamentoRepository, ContaPagamentoRepository>();

//mapper
builder.Services.AddAutoMapper(typeof(EntityToModelMappingProfile), typeof(ModelToEntityMappingProfile));


// ADD services Controller
builder.Services.AddControllers();

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
