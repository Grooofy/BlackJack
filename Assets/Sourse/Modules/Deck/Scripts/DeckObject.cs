using System.Collections.Generic;
using UnityEngine;
using Cards;
using System;
using MegaGigaStack;

namespace Deck
{
    public class DeckObject : MonoBehaviour
    {
        [SerializeField] private List<CardData> _cardsData;
        [SerializeField] private Card _card;

        internal Action DeckComplete;

        private SuperSonicStack<Card> _cards = new SuperSonicStack<Card>();

        public void CreateDeck()
        {
            foreach (var card in _cardsData)
            {
                _cards.Add(_card.CreateNew(card, transform));
            }
            _cards.Shuffle();
            DeckComplete?.Invoke();
        }

        public Card GetCard()
        {
            var firstCArd = _cards.Pop();
            return firstCArd;
        }
    }
}
