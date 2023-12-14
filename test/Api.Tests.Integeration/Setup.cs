//install-package Microsoft.AspNetCore.Mvc.Testing
//install-package fluentassertions

using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;


namespace Api.Tests.Integeration
{
    public class Setup : WebApplicationFactory<Api.Program>
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            return base.CreateHost(builder);
        }
    }
}
