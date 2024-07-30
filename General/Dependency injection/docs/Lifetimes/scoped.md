# Scoped Dependency Injection Definition

Scoped Dependency Injection means that the service instance is created once per request and shared within that request. In the context of an ASP.NET Core-based web application, this means that one service instance will be created for each HTTP request and will be used by all components handling that request.

## Advantages of Scoped Dependency Injection
- <strong>Memory efficiency</strong>: Because the service instance is created once per request and shared within it, it reduces memory consumption compared to the Transient mode, which creates a new instance for each dependency.
- <strong>Adaptation to requests</strong>: Scoped DI is ideal for web applications where multiple operations need to be performed within a single HTTP request. This allows for easy session state management and data sharing between different components within the same request.
- <strong>Avoiding concurrency issues</strong>: Unlike the Singleton mode, Scoped DI avoids concurrency access issues because each service instance is isolated to one request.

## When to use Scoped Dependency Injection? 
Scoped DI is most useful in web applications where different components need to share state within a single HTTP request. Examples of such use cases include: User session management services. Data repositories that need to share the database context within a single request.

## Implementation
```cs
var builder = WebApplication.CreateBuilder(args);

// Register service as Scoped
builder.Services.AddScoped<IService, ScopedService>();

var app = builder.Build();
app.Run();
```

## Did you know?
When using Entity Framework Core, the AddDbContext extension method registers DbContext types with a scoped lifetime by default.
```cs
// This will be registered as Scoped!
builder.Services.AddDbContext<AppDbContext>(
        options => options.UseSqlServer("ConnectionString"));
```