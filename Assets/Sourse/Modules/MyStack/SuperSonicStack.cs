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
            set => _values[index] = value;
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
        }

        public T Peek()
        {
            T newValue = _values[0];

            T[] newArray = new T[_values.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _values[i + 1];
            }
            _values = newArray;

            return newValue;
        }


    }


}
