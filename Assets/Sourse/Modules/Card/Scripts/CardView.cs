using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cards
{
    public class CardView : MonoBehaviour
    {
        [SerializeField] private Image _value;
        [SerializeField] private Image _valueImage;
        [SerializeField] private Image _suit;


        public void InitCard(Sprite value, Sprite valueImage, Sprite suit = null)
        {
            _value.sprite = value;
            _valueImage.sprite = valueImage;

            if (suit != null)
            {
                _suit.enabled = true;
                _suit.sprite = suit;
            }
            else
            {
                _suit.enabled = false;
            }

        }
    }
}
