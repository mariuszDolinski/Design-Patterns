namespace Chain_Of_Responsibility
{
    internal interface IHandler
    {
        void Handle(RequestContext requestContext);
    }
}
