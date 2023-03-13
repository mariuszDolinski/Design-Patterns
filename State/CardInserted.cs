using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class CardInserted : ATMState
    {
        public CardInserted(Context context) : base(context)
        {
        }
        public override void DisplayScreen()
        {
            Console.WriteLine("Operation already began.");
        }
        public override void EjectCard()
        {
            Interface.ShowEjectCardOptions("");
            _context.ChangeState(new NoCard(_context));
            _context.begin();
        }
        public override void InsertCard()
        {
            Console.WriteLine("Card is already inserted");
        }

        public override void InsertPin()
        {
            int responseInt = Interface.ShowInputDataOptions("   Type PIN: ");
            if (responseInt != 0)
            {
                if (responseInt == 1234)
                {
                    _context.ChangeState(new PinInserted(_context));
                    string responseString = Interface.ShowPinInsertedOptions();
                    if(responseString == "1")
                    {
                        _context.WithdrawCash();
                    }
                    else
                    {
                        _context.EjectCard();
                    }
                }
                else
                {
                    Interface.ShowEjectCardOptions("   Wring PIN!");
                    _context.ChangeState(new NoCard(_context));
                    _context.begin();
                }
            }
            else
            {
                Interface.ShowEjectCardOptions("   Wrong PIN!");
                _context.ChangeState(new NoCard(_context));
                _context.begin();
            }
        }

        public override void WithdrawCash()
        {
            Console.Write("Insert pin first");
        }
    }
}
