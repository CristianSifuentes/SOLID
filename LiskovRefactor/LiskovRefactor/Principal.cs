using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovRefactor
{
    abstract class Principal
    {
        protected string message;

        public Principal(string pMessage)
        {
            message = pMessage;
        }
        public abstract void Show();
    }
}
