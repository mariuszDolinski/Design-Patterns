namespace Builder
{
    internal class Person : IPrint
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public void Print()
        {
            if (FirstName == default && LastName == default && City == default)
            {
                Console.WriteLine("--No data--");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName}, {City}");
            }
        }
    }
}
