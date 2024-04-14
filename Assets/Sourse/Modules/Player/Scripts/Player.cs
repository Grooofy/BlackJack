using CardMover;
using Cards;
using Codice.CM.SEIDInfo;
using Deck;
using MegaGigaStack;
using System;
using UnityEngine;

namespace Players
{
    public abstract class Player : MonoBehaviour
    {
        [SerializeField] private Mover _mover;
        private SuperSonicStack<Card> _cards = new SuperSonicStack<Card>();

        internal Action<int> GetCards;
        internal Action<int> Taking;

        internal int _index = 0; 

        public virtual void GetCard(DeckObject deck)
        {
            Get(deck);
            _mover.InitObject(_cards.Peek().transform, transform.GetChild(_cards.Count - 1));
            CalculatePoints();
        }

        internal void CalculatePoints()
        {
            _index = 0;
            for (int i = 0; i < _cards.Count; i++)
            {
                _index += _cards[i].Value;
            }
            Taking?.Invoke(_index);
        }

        internal void Get(DeckObject deck)
        {
            _cards.Add(deck.GetCard());
            GetCards?.Invoke(_cards.Count);
        }
    }
}
