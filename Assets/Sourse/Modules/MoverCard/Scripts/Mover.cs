using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cards;
using UnityEditor;

namespace CardMover
{
    internal class Mover : MonoBehaviour
    {
        [SerializeField] private RectTransform _finishPoint;
        [SerializeField] private float _speed;

        private Card _movedObject;

        public void InitCard(Card card)
        {
            _movedObject = card;
        }

        private void Update()
        {
            if (_movedObject != null)
            {

            }
        }

    }
}
