using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScore : MonoBehaviour
{
    private TextMesh _text; // ScoreText

    void Start()
    {
        _text = GetComponentInChildren<TextMesh>();
        _text.text = "Best Score: " + PlayerPrefs.GetInt("LastPoint", 0).ToString(); //Сохранение количества монет после выхода в главное меню
    }
}
