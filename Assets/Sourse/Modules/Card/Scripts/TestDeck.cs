using System.Collections.Generic;
using UnityEngine;


namespace Cards
{
    internal class TestDeck : MonoBehaviour
    {
        [SerializeField] private List<CardData> _cards;
        [SerializeField] private CardCreater creater;
        [SerializeField] RectTransform rectTransform;


        private void Start()
        {
            CreateCard(_cards);
        }

        private void CreateCard(List<CardData> cardData)
        {
            foreach (var card in cardData)
            {
                creater.Create(card, rectTransform);
            }

        }
    }
}
