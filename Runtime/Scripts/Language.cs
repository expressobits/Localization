using UnityEngine;

namespace ExpressoBits.Localization
{
    // Objeto que contèm informações de línguas, deve ser adicionado um para cada lígua que precisar
    [CreateAssetMenu(fileName = "Language", menuName = "Expresso Bits/Localization/Language", order = 0)]
    public class Language : ScriptableObject
    {

        public Sentence nameLanguage;
        public Sprite flag;

    }
}

