namespace Chain_Of_Responsibility
{
    internal class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next) { }
        public override void Handle(RequestContext requestContext)
        {
            requestContext.Response.IsSuccessful = true;
            requestContext.Response.Data = $"Data no. {requestContext.Request.ResourceId}";
        }
    }
}
