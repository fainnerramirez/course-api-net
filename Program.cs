var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//se agregan lasinyecciópn de dependencias
//forma 1
builder.Services.AddScoped<IAppService, AppService>();
//forma 2
//builder.Services.AddScoped<IAppService>(e => new AppService());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
//aqui van los custom middlewares
//app.UseWelcomePage();
app.UseTimeMiddleware();
app.MapControllers();
app.Run();