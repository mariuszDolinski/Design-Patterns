namespace Chain_Of_Responsibility
{
    //symulacja bazy danych
    internal class DataBase
    {
        //<resourceId, userId>
        public static Dictionary<int, int> ResourceOwners { get; set; } = new Dictionary<int, int>()
        {
            {101, 12 },
            {102, 24 },
            {104, 32 },
            {105, 12 }
        };

        public static List<User> UserList { get; set; } = new List<User>()
        {
            new User()
                {
                    Name = "jankowalski",
                    Id = 24,
                    Role = Roles.REGISTERED_VERIFIED_USER,
                    Password = "pass123"
                },
            new User()
                {
                    Name = "johndoe",
                    Id = 11,
                    Role = Roles.ADMIN,
                    Password = "pa12ss3"
                },
            new User()
                {
                    Name = "flower4351",
                    Id = 12,
                    Role = Roles.REGISTERED_UNVERIFIED_USER,
                    Password = "pass"
                },
            new User()
                {
                    Name = "guest4123",
                    Id = 50,
                    Role = Roles.UNREGISTERED_USER,
                    Password = ""
                }
        };
    }
}
