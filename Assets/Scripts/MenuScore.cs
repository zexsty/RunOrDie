using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScore : MonoBehaviour
{
    private TextMesh _text;

    void Start()
    {
        _text = GetComponentInChildren<TextMesh>();
        _text.text = "Best Score: " + PlayerPrefs.GetInt("LastPoint", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
