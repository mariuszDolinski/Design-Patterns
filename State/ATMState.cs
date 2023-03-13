namespace State
{
    internal abstract class ATMState
    {
        protected Context _context;
        protected ATMState(Context context)
        {
            _context = context;
        }

        public abstract void DisplayScreen();
        public abstract void InsertCard();
        public abstract void EjectCard();
        public abstract void InsertPin();
        public abstract void WithdrawCash();
    }
}
