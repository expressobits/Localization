using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextInject))]
public class TextInject : MonoBehaviour
{

    public Sentence sentence;

    private void Awake() {
        GetComponent<Text>().text = sentence.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
