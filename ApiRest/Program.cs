using ApiRest.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// crear variable cadena de conexi�n
var connectionString = builder.Configuration.GetConnectionString("Connection");
// registrar servicio para la conexi�n
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

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

// Creaci�n de modelos y clases
// Instalaci�n de paquetes: Entity FrameWork Core, Entity SQL Server, Entity FrameWork Tools
// Creaci�n del context 
// Configurar la cadena de conexi�n con la base de datos en appsettings:
// Servidor; Nombre de la base de datos
// Ver -> Explorador de servidores -> Explorador de objetos -> (localdb) -> propiedades -> cadena conexi�n
// En program, crear variable de cadena de conexi�n y registrar un servicio para la conexi�n
// Realizar migraciones: Herramientas -> Administrador de paquetes Nuget -> Consola del administrador de paquetes: 
    // Add-Migration Initial
    // Update-database (antes de ejecutar el comando, hay que cambiar a false el "invariantGlobalization" del ApiRest)