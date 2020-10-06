using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovRefactor
{
    class Radio : Principal
    {
        public Radio(string pMessage) : base(pMessage)
        {

        }

        public override void Show()
        {
            Console.WriteLine("From radio : {0}", message);
        }
    }
}
