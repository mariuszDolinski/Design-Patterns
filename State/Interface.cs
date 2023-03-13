using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Interface
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("**              ATM Simulator              **");
            Console.WriteLine("*********************************************");
        }
        public static string ShowInitialOptions()
        {
            Console.WriteLine("   Insert card -> press Enter");
            Console.WriteLine("   Exit - > type exit and press Enter");
            return Console.ReadLine();
        }

        public static string ShowInsertCardOptions()
        {
            Show();
            Console.WriteLine("   Type PIN -> type 1 and press enter");
            Console.WriteLine("   Eject card -> type 2 and press enter");
            return Console.ReadLine();
        }

        public static void ShowEjectCardOptions(string text)
        {
            Show();
            if (text != "")
            {
                Console.WriteLine(text);
            }
            Console.WriteLine("   Card will be ejected.");
            Console.WriteLine("   Press any key...");
            Console.ReadLine();
        }
        /// <summary>
        /// Display string in output parameter
        /// If integer value is given, return this value
        /// In other case return 0
        /// </summary>
        /// <param name="output">String which should be display on screen</param>
        /// <returns></returns>
        public static int ShowInputDataOptions(string output)
        {
            Show();
            Console.Write(output);
            bool isInt = Int32.TryParse(Console.ReadLine(), out int intValue);
            if(isInt)
            {
                return intValue;
            }
            else
            {
                return default;
            }
        }
        public static string ShowPinInsertedOptions()
        {
            Show();
            Console.WriteLine("   Cash withdraw - > type 1 and press enter");
            Console.WriteLine("   Eject card - > type 2 and press enter");
            return Console.ReadLine();
        }
        public static void ShowNoCashOptions() 
        {
            Show();
            Console.WriteLine("Sorry, we run out of cash.");
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
