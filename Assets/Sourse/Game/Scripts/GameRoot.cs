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
        [SerializeField] private Player _player;
        [SerializeField] private Button _getButton;
        [SerializeField] private Button _toggleButton;


        private void OnEnable()
        {
            _getButton?.onClick.AddListener(PlayerGetCard);
        }

        private void OnDisable()
        {
            _getButton?.onClick.RemoveListener(PlayerGetCard);
        }


        private void Start()
        {
            _deck.CreateDeck();
        }

        private void PlayerGetCard()
        {
            _player.GetCard(_deck);
        }

       
    }
}
