namespace State
{
    internal class NoCard : ATMState
    {
        public NoCard(Context context) : base(context) 
        {
        }

        public override void DisplayScreen()
        {
            Interface.Show();
            string response = Interface.ShowInitialOptions();
            if (response == "exit")
            {
                return;
            }
            else
            {
                _context.InsertCard();
            }
        }
        public override void EjectCard()
        {
            Console.WriteLine("   No card inserted.");
        }
        public override void InsertCard()
        {
            _context.ChangeState(new CardInserted(_context));
            string response = Interface.ShowInsertCardOptions();
            if (response == "1")
            {
                Interface.Show();
                _context.InsertPin();    
            }else
            {
                _context.EjectCard();
            }
        }

        public override void InsertPin()
        {
            Console.WriteLine("   No card inserted.");
        }

        public override void WithdrawCash()
        {
            Console.WriteLine("   No card inserted.");
        }
    }
}
