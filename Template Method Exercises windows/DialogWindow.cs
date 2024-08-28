using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Exercises_windows
{
    class DialogWindow : Window
    {
        protected override void OnPreClose()
        {
            Console.WriteLine("Prompting user to confirm close.");
        }

        protected override void PerformClose()
        {
            Console.WriteLine("Closing Dialog Window.");
        }

        protected override void OnPostClose()
        {
            Console.WriteLine("Logging the close of Dialog Window.");
        }
    }

}
