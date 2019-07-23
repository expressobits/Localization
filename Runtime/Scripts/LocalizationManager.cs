using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace ExpressoBits.Localization
{
    public class LocalizationManager : MonoBehaviour
    {

        public static LocalizationManager instance;

        public Language language;

        private List<IChangeLanguage> languageListeners = new List<IChangeLanguage>();

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }

        public void SetLanguage(Language language)
        {
            this.language = language;
            for (int i = 0; i < languageListeners.Count; i++)
            {
                languageListeners[i].ChangeLanguage();
            }
        }

        public void AddListener(IChangeLanguage languageListener)
        {
            languageListeners.Add(languageListener);
        }


    }
}
