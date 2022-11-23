using Order.Application.Contracts.Hello;

namespace Order.Application.Hello;

public class HelloAppService : IHelloAppService
{
    public Task<string> SayHi(string name)
    {
        return Task.FromResult($"Hello {name ?? "World"}");
    }
}