using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameSettings : MonoBehaviour {

    public Slider musicSlider;
    public Text valueCount;
    public AudioSource music;

    private void Update()
    {
        ChangeVolume();
    }


    //! Метод изменения громкости
    public void ChangeVolume()
    {
        valueCount.text = (musicSlider.value * 10).ToString();
        music.volume = musicSlider.value;
    }

}
