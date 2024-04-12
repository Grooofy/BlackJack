using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    internal class PlayerHand : MonoBehaviour
    {
        [SerializeField] List<Transform> _handPoint;
        [SerializeField] Player _player;

        private int _offsetX = 1;

        private void OnEnable()
        {
            _player.GetCards += TryCreatePoint;
        }

        private void OnDisable()
        {
            _player.GetCards -= TryCreatePoint;
        }


        internal void TryCreatePoint(int count)
        {
            if (count >= 2)
            {
                var newPoint = new GameObject("Point");
                newPoint.transform.parent = transform;
                _handPoint.Add(newPoint.transform);

                if (count % 2 == 0)
                    newPoint.transform.position = new Vector3(count + _offsetX, transform.position.y, transform.position.z);
                else
                    newPoint.transform.position = new Vector3(- count, transform.position.y, transform.position.z);
            }
        }
    }
}
