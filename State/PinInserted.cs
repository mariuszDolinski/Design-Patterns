namespace State
{
    internal class PinInserted : ATMState
    {
        public PinInserted(Context context) : base(context)
        {
        }
        public override void EjectCard()
        {
            Interface.ShowEjectCardOptions("");
            _context.ChangeState(new NoCard(_context));
            _context.begin();
        }

        public override void DisplayScreen()
        {
            Console.WriteLine("Operation already began.");
        }
        public override void InsertCard()
        {
            Console.WriteLine("Card is already inserted");
        }

        public override void InsertPin()
        {
            Console.WriteLine("Correct pin already inserted");
        }

        public override void WithdrawCash()
        {
            int amount = Interface.ShowInputDataOptions("   Type amount to withdraw: ");
            if (amount != 0)
            {
                if (amount > _context.AvailableCash)
                {
                    Interface.ShowEjectCardOptions("   That amount of cash is not available.");

                    _context.ChangeState(new NoCard(_context));
                    _context.begin();
                }
                else
                {
                    Interface.ShowEjectCardOptions($"   {amount} withdrowed from the machine");
                    _context.AvailableCash -= amount;
                    if (_context.AvailableCash == 0)
                    {
                        _context.ChangeState(new NoCash(_context));
                        _context.begin();
                    }
                    else
                    {
                        _context.ChangeState(new NoCard(_context));
                        _context.begin();
                    }
                }
            }
        }
    }
}
