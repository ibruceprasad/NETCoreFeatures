using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NET8_Features.src._6.DesignPattern;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET8_Features.src.DesignPattern
{
    public class OptionPatternUsingConfigurationBuilder
    {        
        private ServiceProvider _serviceProvider;

        public OptionPatternUsingConfigurationBuilder()
        {
            IServiceCollection services = new ServiceCollection();
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("settings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = configurationBuilder.Build();

            // configure the service collection
            services.Configure<MyCustomConfig>(configuration.GetSection("settingssection"));  // Configure() returns IServiceCollection for further chaining

            _serviceProvider = services.BuildServiceProvider();
        }

        public IOptions<MyCustomConfig> GetMyCustomConfig()
            => _serviceProvider.GetRequiredService<IOptions<MyCustomConfig>>();
        
    }
}
