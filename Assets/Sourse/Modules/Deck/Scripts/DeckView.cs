using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Deck
{
    internal class DeckView : MonoBehaviour
    {
        [SerializeField] private DeckObject _deckObject;
        [SerializeField] private GameObject _cover;

        private void OnEnable()
        {
            _deckObject.DeckComplete += ShowCover;
        }

        private void OnDisable()
        {
            _deckObject.DeckComplete -= ShowCover;
        }


        private void ShowCover()
        {
            _cover.transform.SetAsLastSibling();
        }
    }
}
