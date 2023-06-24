using Newtonsoft.Json.Serialization;
using Quizer.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var app = builder.Build();


app.MapControllers();

//if (!app.Environment.IsDevelopment())
//{
//    app.AddGlobalErrorHandling();
//}
app.AddGlobalErrorHandling();
app.Run();
