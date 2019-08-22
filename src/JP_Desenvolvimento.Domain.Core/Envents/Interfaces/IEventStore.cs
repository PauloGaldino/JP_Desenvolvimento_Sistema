namespace JP_Desenvolvimento.Domain.Core.Envents.Interfaces
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}