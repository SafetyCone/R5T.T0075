using System;

using IMicrosoftHostBuilder = Microsoft.Extensions.Hosting.IHostBuilder;


namespace R5T.T0075
{
    public interface IHasConfigureHost<THostBuilder>
        where THostBuilder : IHasConfigureHost<THostBuilder>
    {
        THostBuilder ConfigureHost(Action<IMicrosoftHostBuilder> configureAction);
    }
}
