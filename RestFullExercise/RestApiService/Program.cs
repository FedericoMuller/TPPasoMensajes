var builder = WebApplication.CreateBuilder(args);

// Registra los controladores (InventoryController)
builder.Services.AddControllers();

var app = builder.Build();

// Mapea las rutas de los controladores (ej: api/inventory/...)
app.MapControllers();

app.Run();