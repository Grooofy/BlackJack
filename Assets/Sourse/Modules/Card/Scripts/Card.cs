using UnityEngine;

namespace Cards
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardView _cardView;
        public int Value { get; private set; } 

        private CardObject _card;

           
        public Card Create(CardData cardData, Transform transform)
        {
            _card = new CardObject(cardData);

            var newGameObject = Instantiate(_cardView.gameObject, transform);
            newGameObject.name = $"{cardData.ValueNumber} {cardData.EnumSuit}";

            var newCardVeiw = newGameObject.GetComponent<CardView>();
            ShowCard(newCardVeiw, cardData);

            Value = _card.Value;

            return this;
        }             


        internal void ShowCard(CardView cardView, CardData cardData)
        {
            cardView.InitCard(cardData.Value, cardData.ValueImage, cardData.Suit);
        }
    }
}
