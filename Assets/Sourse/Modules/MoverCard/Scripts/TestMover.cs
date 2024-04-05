using System.Collections;
using System.Collections.Generic;
using Cards;
using UnityEngine;

namespace CardMover
{
    public class TestMover : MonoBehaviour
    {
        [SerializeField] private Mover _mover;
        [SerializeField] private Card _card;


        private void Start()
        {
            _mover.InitCard(_card.GetComponent<RectTransform>());
        }
    }
}
