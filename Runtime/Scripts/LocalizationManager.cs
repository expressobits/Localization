using UnityEngine;

namespace ExpressoBits.Localization
{
    public class LocalizationManager : MonoBehaviour
    {

        public static LocalizationManager instance;

        public Language language;

        //private List<LanguageListener> languageListeners = new List<LanguageListener>();

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
            // for (int i = 0; i < languageListeners.Count; i++)
            // {
            //     //languageListeners[i].OnLanguageChange();
            // }
        }

        // public void AddListener(LanguageListener languageListener)
        // {
        //     //languageListeners.Add(languageListener);
        // }


    }
}
