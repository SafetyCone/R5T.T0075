using System;

using Microsoft.Extensions.Hosting;

using R5T.T0073;


namespace R5T.T0075
{
    public interface IHostBuilder :
        IHasConfigureAppConfiguration<IHostBuilder>,
        IHasConfigureConfiguration<IHostBuilder>,
        IHasConfigureHost<IHostBuilder>,
        IHasConfigureHostConfiguration<IHostBuilder>,
        T0072.IHasConfigureServices<IHostBuilder>,
        IHasConfigureServices<IHostBuilder>
    {
        IHost Build();
    }
}
