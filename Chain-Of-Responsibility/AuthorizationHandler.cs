namespace Chain_Of_Responsibility
{
    internal class AuthorizationHandler : BaseHandler
    {
        public AuthorizationHandler(IHandler next) : base(next) { }
        public override void Handle(RequestContext requestContext)
        {
            var user = DataBase.UserList.FirstOrDefault(u => u.Name == requestContext.Request.User.Name);
            if (user != null) 
            {
                if(user.Password == requestContext.Request.User.Password)
                {
                    requestContext.Request.User.Id = user.Id;
                    requestContext.Request.User.Role = user.Role;
                    _next.Handle(requestContext);
                    return;
                }
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "Authorization failed. Wrong username or password";
        }
    }
}
