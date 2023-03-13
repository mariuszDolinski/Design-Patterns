namespace State
{
    internal class NoCash : ATMState
    {
        public NoCash(Context context) : base(context)
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
                Interface.ShowNoCashOptions();
                _context.begin();
            }
        }
        public override void EjectCard()
        {
            Interface.ShowNoCashOptions();
        }

        public override void InsertCard()
        {
            Interface.ShowNoCashOptions();
        }

        public override void InsertPin()
        {
            Interface.ShowNoCashOptions();
        }

        public override void WithdrawCash()
        {
            Interface.ShowNoCashOptions();
        }
    }
}
