using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StartGameScene
{
    public class TextTranslation : MonoBehaviour
    {
        [SerializeField]
        private TextTranslationArray[] _textTranslationArray;

        void Start()
        {

            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                foreach (var item in _textTranslationArray)
                {
                    item.TranslationText.text = item.RusText;
                }
            }
            else
            {
                foreach (var item in _textTranslationArray)
                {
                    item.TranslationText.text = item.EngText;
                }
            }
        }
    }

    [System.Serializable]
    public class TextTranslationArray
    {
        public TMPro.TextMeshProUGUI TranslationText;
        public string RusText;
        public string EngText;
    }
}