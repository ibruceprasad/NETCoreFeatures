using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET8_Features.src._6.DesignPattern
{
    public class MyCustomConfig
    {
        public string Setting1 { get; set; } = string.Empty;
        public int Setting2 { get; set; }
    }
    public class OptionPatternUsingHostBuilder
    {
        private readonly IHost _host;
        public OptionPatternUsingHostBuilder()
        {
            var hostBuilder = Host.CreateDefaultBuilder();
            hostBuilder.ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("settings.json", optional: true, reloadOnChange: true);
            }).ConfigureServices((context, services) =>
            {
                var configurationRoot = context.Configuration;
                services.Configure<MyCustomConfig>(configurationRoot.GetSection("settingssection"));
            });
            _host = hostBuilder.Build();
        }

        public IOptions<MyCustomConfig> GetMyCustomConfig()
            => _host.Services.GetRequiredService<IOptions<MyCustomConfig>>();

    }
}
