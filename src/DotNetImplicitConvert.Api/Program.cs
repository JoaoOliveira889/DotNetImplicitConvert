var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDependencyInjection();

builder.Services.AddDbContext<InMemoryDbContext>(options =>
    options.UseInMemoryDatabase(databaseName: "InMemoryDatabase"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();