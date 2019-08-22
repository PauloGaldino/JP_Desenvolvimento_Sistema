using JP_Desenvolvimento.Domain.Core.Envents;
using System.Threading.Tasks;

namespace JP_Desenvolvimento.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}