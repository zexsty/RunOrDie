using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    private Player playerScore;
    public GameObject panel;

     void Start()
    {
        playerScore = GetComponent<Player>();
        panel.SetActive(false);   
    }
    void Update()
    {
        if (Player.score == 2)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            panel.SetActive(false);
        }
    }    
}
