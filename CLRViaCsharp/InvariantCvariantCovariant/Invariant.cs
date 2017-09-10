using System;
using System.Collections.Generic;
using System.Text;

namespace CLRViaCsharp.InvariantCvariantCovariant
{
    public class Invariant<T>
    {
        public void ShowType(T type)
        {
            Console.WriteLine(typeof(T));
        }
    }
}
