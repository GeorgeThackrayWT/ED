namespace EDCORE.Helpers
{
    public interface IMyEventAggregator
    {
        void Subscribe<TMessage>(ISubscriber<TMessage> subscriber);
        void Publish<TMessage>(TMessage message);
    }
}