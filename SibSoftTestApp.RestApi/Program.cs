using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using SibSoftTestApp.RestApi.Data;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{
	var builder = WebApplication.CreateBuilder(args);

	// Add services to the container.

	builder.Services.AddControllers();
	// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();

	builder.Logging.ClearProviders();
	builder.Host.UseNLog();

	builder.Services.AddDbContext<SibSoftDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SibSoftAppDbconnectionstring")));

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
}
catch (Exception ex)
{
	logger.Error(ex);
    throw (ex);
}
finally
{
	LogManager.Shutdown();
}