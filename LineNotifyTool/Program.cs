using LineNotifyTool.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSingleton<ResponseCodeService>();


var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Line}/{action=Index}/{id?}");
app.Run();
