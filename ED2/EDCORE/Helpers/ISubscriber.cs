namespace EDCORE.Helpers
{
    public interface ISubscriber<in TMessage>
    {
        void HandleMessage(TMessage message);
    }
}