using UnityEngine;

namespace ExpressoBits.Localization
{
    [System.Serializable]
    public class SentenceTranslated {
        
        public Language language;
        [TextArea]
        public string content;

    }
}