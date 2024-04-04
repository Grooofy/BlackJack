using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    internal class CardObject
    {
        internal int Value { get; private set; }

        internal Suit Suit { get; private set; }

        internal CardObject(CardData data)
        {
            Value = data.ValueNumber;
            Suit = data.EnumSuit;
        }
    }
}
