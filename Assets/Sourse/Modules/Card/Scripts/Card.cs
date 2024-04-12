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

            var newCard = newGameObject.GetComponent<Card>();
            newCard.Value = cardData.ValueNumber;

            return newCard;
        }             


        internal void ShowCard(CardView cardView, CardData cardData)
        {
            cardView.InitCard(cardData.Value, cardData.ValueImage, cardData.Suit);
        }
    }
}
