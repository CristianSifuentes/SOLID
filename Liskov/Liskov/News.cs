using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class News
    {
        protected string message;
        public News(String pMessage)
        {
            message = pMessage;
        }

        public virtual void Show()
        {
            Console.WriteLine("Hello from new {0}", message);
        }

    }
}
