var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapAreaControllerRoute(
    name: "Default",
    pattern: "{Controller = Home}/{Action = Index}/{Id?}"
    );

app.Run();
