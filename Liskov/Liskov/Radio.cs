using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Radio : News
    {
        public Radio(string pMessage): base(pMessage)
        {

        }

        //public new void Muestra()
        //{
        //    Console.WriteLine("Hello from raido {0}: ", message);
        //}

        public override void Show()
        {
            Console.WriteLine("Hello from radio {0}", message);
        }
    }
}
