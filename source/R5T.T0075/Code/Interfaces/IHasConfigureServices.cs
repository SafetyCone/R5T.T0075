using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace R5T.T0075
{
    /// <remarks>
    /// Same name as T011.IHasConfigureServices{TServicesBuilder}, but this includes the <see cref="HostBuilderContext"/>.
    /// </remarks>
    public interface IHasConfigureServices<out TServicesBuilder>
        where TServicesBuilder : IHasConfigureServices<TServicesBuilder>
    {
        TServicesBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configureAction);
    }
}
