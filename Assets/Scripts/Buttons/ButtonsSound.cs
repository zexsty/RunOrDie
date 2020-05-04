using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsSound : MonoBehaviour
{
    public AudioClip ClickPlay;

    private void Awake()
    {
        ClickPlay = GetComponent<AudioClip>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
