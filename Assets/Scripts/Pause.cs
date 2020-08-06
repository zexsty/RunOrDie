using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool _isPause;
    [SerializeField] private Animator _pauseAnim;

    public void OnPause()
    {
        _isPause = true;
         Time.timeScale = 0;
    }

    public void EndPause()
    {
        _isPause = false;
        Time.timeScale = 1;
    }

   public void StartAnim()
    {
       _pauseAnim.SetTrigger("Numbers");
    }   
}
