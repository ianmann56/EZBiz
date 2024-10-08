using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoBiz.Adapters.HttpApi.Routing
{
  public interface IRouteGroupBuilder<TTenant>
  {
    IRouteGroupBuilder<TTenant> AddRoute(string route, Action<IRouteBuilder<TTenant>> configure);
    IRouteGroupBuilder<TTenant> AddGroup(string route, Action<IRouteGroupBuilder<TTenant>> configure);
  }
}