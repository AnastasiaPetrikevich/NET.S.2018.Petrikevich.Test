using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class Sequence<T>
    {
        private T current;
        private T next;
        private Func<T, T, T> function;

        public Sequence(T current, T next, Func<T, T, T> function)
        {
            this.current = current;
            this.next = next;
            this.function = function;
        }

        public IEnumerable<T> GenerateSequance(int quantity)
        {
            if (quantity < 1)
            {
                throw new ArgumentException(nameof(quantity));
            }

            return Generator(quantity);
        }

        private IEnumerable<T> Generator(int quantity)
        {
            while (quantity > 0)
            {
                quantity--;
                yield return current;

                T temp = function(current, next);
                current = next;
                next = temp;
            }

        }
    }
}
