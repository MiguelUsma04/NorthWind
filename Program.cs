HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, ConsoleWriter>();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<IUserActionWriter, FileWriter>();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Aplication started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azúcar refinada");