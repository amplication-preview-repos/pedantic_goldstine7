using Microsoft.AspNetCore.Mvc;

namespace Asd.APIs;

[ApiController()]
public class TestsController : TestsControllerBase
{
    public TestsController(ITestsService service)
        : base(service) { }
}
