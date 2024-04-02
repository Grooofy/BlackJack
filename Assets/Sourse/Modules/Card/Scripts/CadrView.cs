using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cards
{
    public class CadrView : MonoBehaviour
    {
        [SerializeField] private Image _value;
        [SerializeField] private Image _valueImage;
        [SerializeField] private Image _suit;


        public void InitCard(Image value, Image valueImage, Image suit = null)
        {
            _value = value;
            _valueImage = valueImage;

            if (suit != null)
            {
                _suit.enabled = true;
                _suit = suit;
            }
            else
            {
                _suit.enabled = false;
            }

        }
    }
}
