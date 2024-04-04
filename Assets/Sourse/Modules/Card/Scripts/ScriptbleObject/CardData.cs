using UnityEngine;

namespace Cards
{

    [CreateAssetMenu(fileName = "Card name", menuName = "New Card", order = 51)]
    public class CardData : ScriptableObject
    {
        [SerializeField] private Sprite _value;
        [SerializeField] private Sprite _valueImage;
        [SerializeField] private Sprite _suit;
        [SerializeField] private Suit _enumSuit;
        [SerializeField] private int _valueNumber;


        internal Sprite Value => _value;
        internal Sprite ValueImage => _valueImage;
        internal Sprite Suit => _suit;
        internal Suit EnumSuit => _enumSuit;
        internal int ValueNumber => _valueNumber;

    }
}
