using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovRefactor
{
     class New : Principal
     {
        public New(string pMessage): base(pMessage)
        {

        }

        public override void Show()
        {
            Console.WriteLine("From new : {0}", message);
        }
    }
}
