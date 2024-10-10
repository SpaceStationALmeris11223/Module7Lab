var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Add line to enable serving static files
app.UseStaticFiles();


app.Run();
