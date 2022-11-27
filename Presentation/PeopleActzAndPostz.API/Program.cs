using Microsoft.AspNetCore.Diagnostics;
using PeopleActzAndPostz.API.Extensions;
using PeopleActzAndPostz.Application.JwtTokenHelper;
using PeopleActzAndPostz.Domain.Common.AutoMapper.AutoMapperProfiles;
using PeopleActzAndPostz.Domain.Common.Settings;
using PeopleActzAndPostz.Infrastructure.EntityFramework.UnitOfWorks;
using PostZUserZ.Application.Helpers.HelperServices.JwtTokenHelper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureCors();






builder.Services.ConfigureIdentity();
builder.Services.AddAutoMapper(typeof(Maps).Assembly);
builder.Services.LoadApplicationLayerExtensions(builder.Configuration);
builder.Services.LoadDataLayerExtensions(builder.Configuration);
var settings = new JwtSettings();
builder.Configuration.GetSection("Jwt").Bind(settings);

// Add customized Authentication to the services container.
builder.Services.AddCustomizedAuthentication(settings);
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));
builder.Services.AddControllers();
builder.Services.LoadDataLayerExtensions(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


//// Configure the HTTP request pipeline.
//// global error handler
app.AddGlobalErrorHandler();


app.UseStatusCodePages();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
    