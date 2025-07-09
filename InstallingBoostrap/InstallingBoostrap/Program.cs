var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name : "Default",
    pattern : "{ Controller=Home}/{ Action=Index}/{ Id?}"
    );

app.Run();
