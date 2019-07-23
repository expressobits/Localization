using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ExpressoBits.Localization
{
    [RequireComponent(typeof(TextInject))]
    public class TextInject : MonoBehaviour,IChangeLanguage
    {

        public Sentence sentence;

        public void ChangeLanguage()
        {
            GetComponent<Text>().text = sentence.ToString();
        }

        private void Awake() {
            LocalizationManager.instance.AddListener(this);
        }

        // Start is called before the first frame update
        void Start()
        {
            ChangeLanguage();
        }

        private void OnDestroy() {
            LocalizationManager.instance.RemoveListener(this);
        }
    }
}


