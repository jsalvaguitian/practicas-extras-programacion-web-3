var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//inyeccion de dependencia
builder.Services.AddSingleton<Servicios.IHerramientaServicio, Servicios.HerramientaServicio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Principal}/{id?}");

app.MapControllerRoute(
    name: "default2",
    pattern: "{controller=Herramienta}/{action=Index}/{id?}");


app.Run();

/*1
.MapControllerRoute define las plantillas de ruta de nuestra app.
name: "default", (nombre de ruta)
pattern: "{controller=Home}/{action=Index}/{id?}")
el patern es lo que me dice que todas las rutas tendran esa forma
como {id?} tiene un ? esto quiere decir que es un parametro opcional
{controller=Home}/{action=Index
lo que esta despues del igual sera el valor por defecto,
es decir si yo lanzo la url localhost:puertoip/nombreController se mostrara
la vista relacionado ese controlle si yo no paso el nombreControle lanzara el controlador
home por defecto y su metodo o action Index.
Si vamos al HomeController veremos algunas acciones
*/

