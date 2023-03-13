namespace State
{
    internal class Context
    {
        private ATMState _currentState;
        public int AvailableCash { get; set; } = 1000;

        public Context()
        {
            _currentState = new NoCard(this);
        }
        
        public void ChangeState(ATMState newState)
        {
            _currentState = newState;
        } 
        public void begin()
        {
            _currentState.DisplayScreen();
        }
        public void InsertCard()
        {
            _currentState.InsertCard();
        }
        public void EjectCard()
        {
            _currentState.EjectCard();
        }
        public void InsertPin()
        {
            _currentState.InsertPin();
        }
        public void WithdrawCash()
        {
            _currentState.WithdrawCash();
        }
    }
}
