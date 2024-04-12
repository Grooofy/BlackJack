using UnityEngine;
using Deck;
using CardMover;

namespace BlackJack
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private DeckObject deck;
        [SerializeField] private Mover mover;
        [SerializeField] private Transform player;


        private void Start()
        {
            deck.CreateDeck();

        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                mover.InitObject(deck.GetFirstCard().transform, player);
            }
        }
    }
}
