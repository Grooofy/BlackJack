using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public class TestCreated : MonoBehaviour
    {
        [SerializeField] private List<CardData> _cards;
        [SerializeField] private CardView _cardView;

        private Card _card;


        private void Start()
        {
            _cardView.InitCard(_cards[5].Value, _cards[5].ValueImage, _cards[5].Suit);

        }

    }
}
