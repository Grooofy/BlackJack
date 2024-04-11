
using Mono.Cecil.Cil;
using System;

namespace MegaGigaStack
{
    public class SuperSonicStack<T>
    {
        private T _value;
        private T[] _values = new T[0];

        public SuperSonicStack(T value)
        {
            _value = value;
        }

        public void Add(T value)
        {
            if (value.GetType() != _value.GetType())
                throw new ArgumentException();

            T[] newArray = new T[_values.Length + 1];

            newArray[0] = value;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = _values[i];
            }

            _values = newArray;
        }
    }
}
