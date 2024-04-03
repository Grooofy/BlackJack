using UnityEngine;

namespace Cards
{
    internal class CardCreater : MonoBehaviour
    {
        [SerializeField] private CardView _cardView;

        private Card _card;


        public void Create(CardData cardData, RectTransform rectTransform)
        {
            _card = new Card(cardData);
            var newGameObject = Instantiate(_cardView.gameObject, rectTransform);
            newGameObject.name = $"{cardData.ValueNumber} {cardData.EnumSuit}";
            var newCardVeiw = newGameObject.GetComponent<CardView>();
            ShowCard(newCardVeiw, cardData);
        }


        internal void ShowCard(CardView cardView, CardData cardData)
        {
            cardView.InitCard(cardData.Value, cardData.ValueImage, cardData.Suit);
        }
    }
}
