using UnityEngine;
using TMPro;


namespace Players
{
    internal class Score : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private TextMeshProUGUI texMeshProUGUI;


        private void OnEnable()
        {
            _player.Taking += ShowScore;
        }

        private void OnDisable()
        {
            _player.Taking -= ShowScore;
        }

        internal void ShowScore(int value)
        {
            texMeshProUGUI.text = value.ToString();
        }
    }
}
