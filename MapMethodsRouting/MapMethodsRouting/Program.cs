var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This Is Home Page");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This Is Home Page");
    });

    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This Is Home Page");
    });

    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This Is Home Page");
    });
});

//app.MapGet("/", () => "Hello World!-GET");
//app.MapPost("/", () => "Hello World!-POST");
//app.MapPut("/", () => "Hello World!-PUT");
//app.MapDelete("/", () => "Hello World!-DELETE");

app.Run();
