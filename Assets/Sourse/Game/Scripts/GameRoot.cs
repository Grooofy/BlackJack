using UnityEngine;
using Deck;
using CardMover;
using Players;
using UnityEngine.UI;

namespace BlackJack
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private DeckObject _deck;
        [SerializeField] private Gamer _player;
        [SerializeField] private AIGamer _amer;

        [SerializeField] private Button _getButton;
        [SerializeField] private Button _toggleButton;


        private void OnEnable()
        {
            _getButton?.onClick.AddListener(PlayerGetCard);
            _toggleButton?.onClick.AddListener(AIPlayer);
        }

        private void OnDisable()
        {
            _getButton?.onClick.RemoveListener(PlayerGetCard);
            _toggleButton.onClick.RemoveListener(AIPlayer);
        }


        private void Start()
        {
            _deck.CreateDeck();
        }

        private void PlayerGetCard()
        {
            _player.GetCard(_deck);
        }

        private void AIPlayer()
        {
            _amer.GetCard(_deck);
        }

       
    }
}
