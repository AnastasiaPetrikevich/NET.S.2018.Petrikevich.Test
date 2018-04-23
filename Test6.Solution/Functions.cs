using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public static class Functions<T>
    {
        public static T FirstFunction(T current, T next) => (dynamic)next + (dynamic)current;
        public static T SecondFunction(T current, T next) => 6 * (dynamic)next - 8 * (dynamic)current;
        public static T ThirdFunction(T current, T next) => (dynamic)next + (dynamic)current / (dynamic)next;

    }
}
