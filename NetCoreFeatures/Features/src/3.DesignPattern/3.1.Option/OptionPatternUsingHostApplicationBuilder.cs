using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET8_Features.src._6.DesignPattern
{
    public  class OptionPatternUsingHostApplicationBuilder
    {
        IHost _host;
        public OptionPatternUsingHostApplicationBuilder()
        {
            var builder = Host.CreateApplicationBuilder();
            builder.Logging.AddConsole();
            builder.Configuration.AddJsonFile("settings.json", optional: false, reloadOnChange: true);
            builder.Services.Configure<MyCustomConfig>(builder.Configuration.GetSection("settingssection"));
            _host = builder.Build();
        }


        public IOptions<MyCustomConfig> GetMyCustomConfig()
            => _host.Services.GetRequiredService<IOptions<MyCustomConfig>>();


    }
}
