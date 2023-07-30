using cerveza.application;
using cerveza.domain.contracts;
using cerveza.domain.services;
using cerveza.infraestructure.repository;
using AutoMapper;
using cerveza.api.mappers;
using cerveza.application.Constans;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//mapper
var mapperConfig = new MapperConfiguration(m =>
{
    m.AllowNullCollections = true;
    m.AddProfile<MappingProfile>();
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//load settings
builder.Services.Configure<CerbezaSetting>(
    builder.Configuration.GetSection(CerbezaSetting.Root)
);

//DDD
builder.Services.AddScoped<IApplicationServices, ApplicationServices>();
builder.Services.AddScoped<ICervezaServices, CervezaServices>();
builder.Services.AddScoped<ICervezaRepository, CervezaRepository>();

//API
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
