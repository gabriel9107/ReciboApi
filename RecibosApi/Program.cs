using RecibosApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var startup = new StartUp(builder.Configuration);
startup.configureServices(builder.Services);


var app = builder.Build();


startup.configure(app, app.Environment);


app.Run();
