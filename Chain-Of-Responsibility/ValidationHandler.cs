using System.Runtime.Intrinsics.Arm;

namespace Chain_Of_Responsibility
{
    internal class ValidationHandler : BaseHandler
    {
        public ValidationHandler(IHandler next) : base(next) { }
        public override void Handle(RequestContext requestContext)
        {
            if (DataBase.ResourceOwners.TryGetValue(requestContext.Request.ResourceId, out int id))
            {
                 _next.Handle(requestContext);
                 return;
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "Validation error. Resource not found.";
        }
    }
}
