namespace Chain_Of_Responsibility
{
    internal class AuthenticationHandler : BaseHandler
    {  
        public AuthenticationHandler(IHandler next) : base(next) { }
        public override void Handle(RequestContext requestContext)
        {
            if(requestContext.Request.User.Role == Roles.ADMIN) 
            {
                _next.Handle(requestContext);
                return;
            }
            if(requestContext.Request.User.Role == Roles.REGISTERED_VERIFIED_USER) 
            {
                if (DataBase.ResourceOwners[requestContext.Request.ResourceId] == requestContext.Request.User.Id)
                {
                    _next.Handle(requestContext);
                    return;
                }
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "Authentication failed.";
        }
    }
}
