using System;
using System.Collections.Generic;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IMicrosoftHostBuilder = Microsoft.Extensions.Hosting.IHostBuilder;
using MicrosoftHostBuilder = Microsoft.Extensions.Hosting.HostBuilder;


namespace R5T.T0075
{
    public class HostBuilder : IHostBuilder
    {
        private MicrosoftHostBuilder MicrosoftHostBuilder { get; } = new MicrosoftHostBuilder();
        private List<Action<IMicrosoftHostBuilder>> HostBuilderConfigureActions { get; } = new List<Action<IMicrosoftHostBuilder>>();


        public IHost Build()
        {
            foreach (var hostBuilderConfigureAction in this.HostBuilderConfigureActions)
            {
                hostBuilderConfigureAction(this.MicrosoftHostBuilder);
            }

            var output = this.MicrosoftHostBuilder.Build();
            return output;
        }

        public IHostBuilder ConfigureAppConfiguration(Action<HostBuilderContext, IConfigurationBuilder> configureAction)
        {
            this.MicrosoftHostBuilder.ConfigureAppConfiguration(configureAction);

            return this;
        }

        public IHostBuilder ConfigureHost(Action<IMicrosoftHostBuilder> configureAction)
        {
            this.HostBuilderConfigureActions.Add(configureAction);

            return this;
        }

        public IHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureAction)
        {
            this.MicrosoftHostBuilder.ConfigureHostConfiguration(configureAction);

            return this;
        }

        public IHostBuilder ConfigureServices(Action<IServiceCollection> configureAction)
        {
            this.MicrosoftHostBuilder.ConfigureServices(configureAction);

            return this;
        }

        public IHostBuilder ConfigureConfiguration(Action<IConfigurationBuilder> configureAction)
        {
            this.MicrosoftHostBuilder.ConfigureHostConfiguration(configureAction);

            return this;
        }

        public IHostBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configureServicesAction)
        {
            this.MicrosoftHostBuilder.ConfigureServices(configureServicesAction);

            return this;
        }
    }
}
