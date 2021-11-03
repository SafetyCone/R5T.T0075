using System;

using Microsoft.Extensions.Configuration;


namespace R5T.T0075
{
    public interface IHasConfigureHostConfiguration<THostConfigurationBuilder>
        where THostConfigurationBuilder : IHasConfigureHostConfiguration<THostConfigurationBuilder>
    {
        THostConfigurationBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureAction);
    }
}
