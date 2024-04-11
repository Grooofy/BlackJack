using System.Collections;
using UnityEngine;

namespace Cards
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardView _cardView;
        public int Value { get; private set; } 
        
        public Card CreateNew(CardData cardData, Transform transform)
        {
            var newGameObject = Instantiate(_cardView.gameObject, transform);
            newGameObject.name = $"{cardData.ValueNumber} {cardData.EnumSuit}";

            var newCardVeiw = newGameObject.GetComponent<CardView>();
            ShowCard(newCardVeiw, cardData);

            Value = cardData.ValueNumber;

            return newGameObject.GetComponent<Card>();
        }             


        internal void ShowCard(CardView cardView, CardData cardData)
        {
            cardView.InitCard(cardData.Value, cardData.ValueImage, cardData.Suit);
        }
    }
}
