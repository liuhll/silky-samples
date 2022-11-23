using Microsoft.AspNetCore.Mvc;
using Silky.Rpc.Routing;

namespace Order.Application.Contracts.Hello;

[ServiceRoute]
public interface IHelloAppService
{
    Task<string> SayHi([FromQuery]string name);
}