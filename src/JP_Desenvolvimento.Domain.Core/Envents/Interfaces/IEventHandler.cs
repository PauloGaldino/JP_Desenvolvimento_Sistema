namespace JP_Desenvolvimento.Domain.Core.Envents.Interfaces
{
    public interface IEventHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}