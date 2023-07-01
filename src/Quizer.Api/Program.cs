using Newtonsoft.Json.Serialization;
using Quizer.Api.Middlewares;
using Quizer.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
    //.AddNewtonsoftJson(cfg =>
    //{
    //    cfg.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    //    cfg.SerializerSettings.ContractResolver = new DefaultContractResolver
    //    {
    //        NamingStrategy = new CamelCaseNamingStrategy()
    //    };
    //});

builder.Services.AddBussinessLogic(builder.Configuration);

var app = builder.Build();


app.MapControllers();

//if (!app.Environment.IsDevelopment())
//{
//    app.AddGlobalErrorHandling();
//}
app.AddGlobalErrorHandling();
app.Run();
