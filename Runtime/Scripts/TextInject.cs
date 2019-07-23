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

        // Start is called before the first frame update
        void Start()
        {
            ChangeLanguage();
        }
    }
}


