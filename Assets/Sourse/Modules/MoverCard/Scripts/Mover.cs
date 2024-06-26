using UnityEngine;
using DG.Tweening;



namespace CardMover
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _duration;

        private Transform _startPosition;
        private Vector3 _endPosition;
        private Tween _tween;
        private bool _isMove;

        public void InitObject(Transform startPosition, Transform finishPosition)
        {
            _startPosition = startPosition;

            if (_startPosition == null || finishPosition == null)
                InitObject(startPosition, finishPosition);

            _endPosition = new Vector3(finishPosition.position.x, finishPosition.position.y, finishPosition.position.z);

            _isMove = true;
        }

        private void Update()
        {
            if (_isMove)
            {
                _tween = _startPosition.DOMove(_endPosition, _duration);
                _isMove = _tween.IsComplete();
            }
        }

    }
}
