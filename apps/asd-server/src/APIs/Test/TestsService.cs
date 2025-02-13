using Asd.Infrastructure;

namespace Asd.APIs;

public class TestsService : TestsServiceBase
{
    public TestsService(AsdDbContext context)
        : base(context) { }
}
