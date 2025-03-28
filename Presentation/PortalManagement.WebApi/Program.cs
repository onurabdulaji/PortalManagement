using PortalManagement.Persistence.Extensions;
using PortalManagement.Application.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Persistence Layer Extension
builder.Services.AddDatabaseExtension(builder.Configuration);
builder.Services.AddIdentityExtensions();
builder.Services.AddGenericPatternExtension();
builder.Services.AddRepositoriesExtension();
builder.Services.AddUnitOfWorkExtension();
#endregion

#region Application Layer Extension
builder.Services.AddMediatorExtension();
builder.Services.AddServiceAndManagersExtensions();
#endregion

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
