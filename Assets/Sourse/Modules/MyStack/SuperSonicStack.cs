
using Mono.Cecil.Cil;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MegaGigaStack
{
    public class SuperSonicStack<T> 
    {
        private T[] _values;

        public SuperSonicStack()
        {
            _values = new T[0];
        }

        public int Count;

        public T this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }

        public void Add(T value)
        {
            T[] newArray = new T[_values.Length + 1];

            newArray[0] = value;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = _values[i - 1];
            }

            _values = newArray;
            Count = _values.Length;
        }
    }


}
