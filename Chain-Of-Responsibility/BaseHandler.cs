namespace Chain_Of_Responsibility
{
    internal abstract class BaseHandler : IHandler
    {
        protected IHandler _next;// rferencja do kolejnego obiektu w łańcuchu

        protected BaseHandler(IHandler next)
        {
            _next = next;
        }
        public abstract void Handle(RequestContext requestContext);
    }
}
