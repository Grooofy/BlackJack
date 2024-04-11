using System.Collections.Generic;
using UnityEngine;
using Cards;
using System;

namespace Deck
{
    public class DeckObject : MonoBehaviour
    {
        [SerializeField] private List<CardData> _cardsData;
        [SerializeField] private Card _card;

        internal Action DeckComplete;


        private List<Card> _cards = new List<Card>();

        public void CreateDeck()
        {
            foreach (var card in _cardsData)
            {
                _cards.Add(_card.CreateNew(card, transform));
            }
            DeckComplete?.Invoke();
        }

        public Card GetRandomCard()
        {
            var randomCard = _cards[UnityEngine.Random.Range(0, _cards.Count)];
            return randomCard;  
        }
    }
}
