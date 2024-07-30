var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<SingletonService>();
builder.Services.AddScoped<ScopedService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("singleton", (SingletonService service) =>
{
    return service.HelloWorld();
});

app.MapGet("scoped", (ScopedService service) =>
{
    return service.HelloWorld();
});

app.Run();


public class SingletonService : IService
{
    private readonly string Id = Guid.NewGuid().ToString();
    public string HelloWorld() => $"Hello World {Id}";
}
public class ScopedService : IService
{
    private readonly string Id = Guid.NewGuid().ToString();
    public string HelloWorld() => $"Hello World {Id}";
}

public interface IService
{
    string HelloWorld();
}