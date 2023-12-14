//install-package Microsoft.AspNetCore.Mvc.Testing
//install-package fluentassertions

using Microsoft.AspNetCore.Mvc.Testing;


namespace Api.Tests.Integeration
{
    public class Setup : WebApplicationFactory<Api.Program>
    {

    }
}
