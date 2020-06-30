using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void LoadMainLevel()
    {
        Application.LoadLevel("Level_1");
        Time.timeScale = 1;
    }

    public void LoadMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

}
