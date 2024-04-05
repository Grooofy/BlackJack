using System.Collections;
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
        [SerializeField] RectTransform rectTransform;

        internal Action DeckComplete;


        private List<Card> _cards = new List<Card>();

        public void CreateDeck()
        {
            foreach (var card in _cardsData)
            {
                _cards.Add(_card.Create(card, rectTransform));
            }
            DeckComplete?.Invoke();
        }
    }
}
