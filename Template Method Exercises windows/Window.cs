using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Exercises_windows
{
    using System;

    abstract class Window
    {
        // Template Method
        public void Close()
        {
            OnPreClose();

            PerformClose();

            OnPostClose();
        }

        protected abstract void OnPreClose();

        protected abstract void OnPostClose();

        protected abstract void PerformClose();
    }

}
