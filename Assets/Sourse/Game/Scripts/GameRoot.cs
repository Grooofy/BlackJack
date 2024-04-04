using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Deck;

namespace BlackJack
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private DeckObject deck;


        private void Start()
        {
            deck.CreateDeck();
        }
    }
}
