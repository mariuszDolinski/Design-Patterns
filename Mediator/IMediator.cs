namespace Mediator
{
    internal interface IMediator
    {
        void Notify (Component sender, Args arg);
    }
}