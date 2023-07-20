<<<<<<< HEAD:DemandAndSupply_FileUpload/Program.cs
using DemandAndSupply_FileUpload.Models;
using DemandAndSupply_FileUpload.Repository;
=======
using FileuploadApi.Models;
>>>>>>> dec20f2948a23f207f9283869bfbd944bf7a54e4:Deamnd&Supply_FileUpload/FileuploadApi/Program.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ILogin, LoginRepo>();
builder.Services.AddScoped<IToken,DemandAndSupply_FileUpload.Repository.TokenHandler>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))

    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DemandAndSupply_Db1Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));

});   
<<<<<<< HEAD:DemandAndSupply_FileUpload/Program.cs

builder.Services.AddSwaggerGen(options =>
            {
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "JWT Authentication",
                    Description = "Enter a valid JWT bearer token",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                options.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {securityScheme, new string[] { } }
                });
            });
=======
>>>>>>> dec20f2948a23f207f9283869bfbd944bf7a54e4:Deamnd&Supply_FileUpload/FileuploadApi/Program.cs

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
     app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Login_RegistrationAPI v1"));
}


app.UseHttpsRedirection();
<<<<<<< HEAD:DemandAndSupply_FileUpload/Program.cs

=======
>>>>>>> dec20f2948a23f207f9283869bfbd944bf7a54e4:Deamnd&Supply_FileUpload/FileuploadApi/Program.cs
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseAuthorization();

app.MapControllers();

app.Run();

