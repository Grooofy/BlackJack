using UnityEngine;

namespace Cards
{

    [CreateAssetMenu(fileName = "Card name", menuName = "New Card", order = 51)]
    public class CardData : ScriptableObject
    {
        [SerializeField] private Sprite _value;
        [SerializeField] private Sprite _valueImage;
        [SerializeField] private Sprite _suit;


        public Sprite Value => _value;
        public Sprite ValueImage => _valueImage;
        public Sprite Suit => _suit;

    }
}
