using Redis.OM;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("redis");
var provider = new RedisConnectionProvider(connectionString);
var result = await provider.Connection.ExecuteAsync("PING");
var app = builder.Build();
// var logger = app.Services.GetService<ILogger>();
app.Logger.LogInformation($"Connection string for redis: {connectionString}");
app.Logger.LogInformation($"Result of Redis Ping: {result}");
// logger.LogInformation($"Connection string for redis: {connectionString}");
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
