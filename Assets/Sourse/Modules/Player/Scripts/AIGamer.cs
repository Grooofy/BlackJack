using Deck;
using System.Diagnostics;
using UnityEngine;

namespace Players
{
    public class AIGamer : Player
    {
        private int _value;
        private const int _winValue = 21;
        private const int _middleValue = 18;

        public override void GetCard(DeckObject deck)
        {
            base.GetCard(deck);

            switch (_index)
            {
                case _winValue:
                    Destroy(gameObject);
                    break;

                case _middleValue:
                    new WaitForSeconds(2);
                    GetCard(deck);
                    break;

                default:
                    new WaitForSeconds(2);
                    GetCard(deck);
                    break;

            }

        }


    }
}
