using System;
using System.Collections.Generic;
using System.Text;

namespace FourthNameSpace 
{

    namespace aNameSpace  // ВЛОЖЕННОЕ ПРОСТРАНСТВО ИМЕН!
    {
        class FourthA
        {
            public void Print()
            {
                Console.WriteLine("Класс FourthA");
            }
        }
    }
    namespace bNameSpace  // ВЛОЖЕННОЕ ПРОСТРАНСТВО ИМЕН!
    {
        class FourthB
        {
            public void Print()
            {
                Console.WriteLine("Класс FourthB");
            }
        }
    }


}
