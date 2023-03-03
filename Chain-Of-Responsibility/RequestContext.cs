namespace Chain_Of_Responsibility
{
    internal class Request
    {
        public User User { get; set; } = new User();
        public int ResourceId { get; set; }
    }
    internal class Response
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
    internal class RequestContext
    {
        public Request Request { get; set; }
        public Response Response { get; set; }
    }
}
