using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameSettings : MonoBehaviour {

    public Slider musicSlider; // Слайдер настройки громкости
    public Text valueCount; // Текст значения громкости
    public AudioSource music; // Музыка

    private void Update()
    {
        ChangeVolume();
    }


    //! Метод изменения громкости
    public void ChangeVolume()
    {
        valueCount.text = (musicSlider.value * 10).ToString(); // Слайдер имеет значение 10
        music.volume = musicSlider.value; // Изменение значения при использовании слайдера
    }

}
