using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Exercises_windows
{
    class SaveWindow : Window
    {
        protected override void OnPreClose()
        {
            Console.WriteLine("Saving changes...");
        }

        protected override void PerformClose()
        {
            Console.WriteLine("Closing Save Window.");
        }

        protected override void OnPostClose()
        {
            Console.WriteLine("Clean up after closing Save Window.");
        }
    }

}
