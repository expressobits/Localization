using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace ExpressoBits.Localization
{
    [CreateAssetMenu(fileName = "Sentence", menuName = "Expresso Bits/Localization/Sentence", order = 1)]
    public class Sentence : ScriptableObject
    {

        public List<SentenceTranslated> texts;

        public override string ToString()
        {
            return GetText();
        }

        public string GetText(Language language){
            for (int i = 0; i < texts.Count; i++)
            {
                if(texts[i].language == language){
                    return texts[i].content;
                }
            }
            return "Default text";
        }

        public string GetText(){
            Language language = LocalizationManager.instance.language;
            if(language == null) Debug.LogError("No have localization manager in scene! Add new localization manager in main scene");
            for (int i = 0; i < texts.Count; i++)
            {
                if(texts[i].language == language){
                    return texts[i].content;
                }
            }
            return "Default text";
        }

    }

}

