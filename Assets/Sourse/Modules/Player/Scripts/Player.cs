using CardMover;
using Cards;
using Codice.CM.SEIDInfo;
using Deck;
using MegaGigaStack;
using System;
using UnityEngine;

namespace Players
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Mover _mover;
        private SuperSonicStack<Card> _cards = new SuperSonicStack<Card>();

        internal Action<int> GetCards;

        private int _index = 0; 

        public void GetCard(DeckObject deck)
        {
            Get(deck);
            _mover.InitObject(_cards.Peek().transform, transform.GetChild(_cards.Count - 1));
            CalculatePoints();
        }

        internal void CalculatePoints()
        {
            for (int i = 0; i < _cards.Count; i++)
            {
                _index += _cards[i].Value;
            }
        }

        internal void Get(DeckObject deck)
        {
            _cards.Add(deck.GetCard());
            GetCards?.Invoke(_cards.Count);
        }
    }
}
