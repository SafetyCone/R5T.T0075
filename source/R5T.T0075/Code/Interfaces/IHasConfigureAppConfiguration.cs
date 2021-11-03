using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;


namespace R5T.T0075
{
    public interface IHasConfigureAppConfiguration<TAppConfigurationBuilder>
        where TAppConfigurationBuilder : IHasConfigureAppConfiguration<TAppConfigurationBuilder>
    {
        TAppConfigurationBuilder ConfigureAppConfiguration(Action<HostBuilderContext, IConfigurationBuilder> configureAction);
    }
}
