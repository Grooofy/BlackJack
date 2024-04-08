using System.Collections;
using System.Collections.Generic;
using Cards;
using UnityEngine;

namespace CardMover
{
    public class TestMover : MonoBehaviour
    {
        [SerializeField] private Transform finishPosition;
        [SerializeField] private Mover _mover;
        [SerializeField] private Card _card;


        private void Start()
        {
            _mover.InitObject(_card.GetComponent<Transform>(), finishPosition);
        }
    }
}
