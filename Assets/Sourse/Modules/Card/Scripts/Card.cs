using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    internal class Card
    {
        public int Value { get; private set; }

        public Suit Suit { get; private set; }

        public CardData Data { get; private set; }

        public Card(int value, Suit suit, CardData data)
        {
            Value = value;
            Suit = suit;
            Data = data;
        }
    }
}
