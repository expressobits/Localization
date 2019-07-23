using UnityEngine;

[CreateAssetMenu(fileName = "Sentence", menuName = "Sentence TTU/Sentence", order = 0)]
public class Sentence : ScriptableObject {

    public string key;
    public string content;

    public override string ToString(){
        return content;
    }
}