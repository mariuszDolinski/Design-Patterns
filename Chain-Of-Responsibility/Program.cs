// Chcain of Resonisbility (Łańcuch odpowiedzialności) - wzorzec służący do przekazywania zadań wzdłuż
//      łańcucha obiektów obługujących dane żądanie. Obiekt może przekazać żądanie do kolejnego obiektu w łańcuchu
//      lub zakończyć łańcuch. Przykład: aplikacja webowa, której klient chce pobrać zasób. Przed pobraniem
//      trzeba sprawdzić czy klient jest zalogowany (autoryzacja),  czy zapytanie jest poprawne (walidacja),
//      czy ma odpowiednie uprawnienia (autentykacja). Mamy zatem łańcuch czynności. Najpierw implementujemy
//      wyjściowy interfejs, na którym budujemy abstrakcyjną klasę BaseHandler, po której będą dziedziczyły 
//      poszczególne ogniwa łańcucha

using Chain_Of_Responsibility;

Console.Write("Type username: ");
string userName = Console.ReadLine();

Console.Write("Type password: ");
string password = Console.ReadLine();

Console.Write("Type data id to get: ");
string dataId = Console.ReadLine();

var requestContext = new RequestContext()
{
    Request = new Request()
    {
        ResourceId = Int32.Parse(dataId),
        User = new User() 
        {
            Name = userName,
            Id = default,
            Role = default,
            Password = password
        }
    },
    Response = new Response()
};

var resultHandler = new ResultHandler(null);
var authenticationHandler = new AuthenticationHandler(resultHandler);
var validationHandler = new ValidationHandler(authenticationHandler);
var authorizationHandler = new AuthorizationHandler(validationHandler);

authorizationHandler.Handle(requestContext);

string success = (requestContext.Response.IsSuccessful) ? "successful" : "failed";

Console.WriteLine($"Request is {success}.");
Console.WriteLine($"Message: {requestContext.Response.Message}");
Console.WriteLine($"Data: {requestContext.Response.Data}");