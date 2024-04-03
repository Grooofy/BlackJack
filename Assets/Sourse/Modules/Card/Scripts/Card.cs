using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    internal class Card
    {
        internal int Value { get; private set; }

        internal Suit Suit { get; private set; }

        internal Card(CardData data)
        {
            Value = data.ValueNumber;
            Suit = data.EnumSuit;
        }
    }
}
