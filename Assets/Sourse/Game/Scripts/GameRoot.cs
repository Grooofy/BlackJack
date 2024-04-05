using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Deck;
using CardMover;

namespace BlackJack
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private DeckObject deck;
        [SerializeField] private Mover mover;


        private void Start()
        {
            deck.CreateDeck();

        }
    }
}
