using System;

namespace MegaGigaStack
{
    public class SuperSonicStack<T>
    {
        public int Count;

        public SuperSonicStack()
        {
            _values = new T[0];
            Count = _values.Length;
        }


        public T this[int index]
        {
            get => _values[index];
        }

        private T[] _values;

        public void Add(T value)
        {
            T[] newArray = new T[_values.Length + 1];

            newArray[0] = value;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = _values[i - 1];
            }
            _values = newArray;
            Count = newArray.Length;
        }

        public T Pop()
        {
            T newValue = _values[0];

            T[] newArray = new T[_values.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _values[i + 1];
            }
            _values = newArray;
            Count = newArray.Length;
            return newValue;
        }

        public T Peek()
        {
            T newValue = _values[0];
            
            return newValue;
        }

        public void Shuffle()
        {
            for (int i = 0; i < _values.Length; i++)
                Swap(i, CreateRandomNumber());
        }

        private int CreateRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, _values.Length - 1);
        }

        private void Swap(int a, int b)
        {
            T temp = _values[a];
            _values[a] = _values[b];
            _values[b] = temp;
        }
    }
}



