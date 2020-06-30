using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool paused = false;
    [SerializeField] private GameObject _pauseMenu;

    public void PauseTime()
    {
            Time.timeScale = 0;
        paused = true;
    }

    public void EndPause ()
    {
            Time.timeScale = 1;
        paused = false;
    }
}
