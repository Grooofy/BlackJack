using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cards;
using UnityEditor;
using DG;
using DG.Tweening;

namespace CardMover
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private RectTransform _finishPoint;
        [SerializeField] private float _speed;

        private RectTransform _startPosition;
        private Vector3 _endPosition;
        private bool _isMove;

        public void InitCard(RectTransform startPosition)
        {
            _startPosition = startPosition;

            _endPosition = new Vector3(_finishPoint.position.x, _finishPoint.position.y, _finishPoint.position.z);

            if (_startPosition == null)
                InitCard(startPosition);

            _isMove = true ;
        }

        private void Update()
        {
            if (_isMove)
            {
                 _isMove = _startPosition.DOMove(_endPosition, _speed).IsComplete();
            }
        }

    }
}
