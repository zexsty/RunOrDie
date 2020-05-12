﻿
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    //Public Variable
    public static int score; // Количество монет
    public GameObject pausePanel; //Панель паузы
    public SpriteRenderer aura; // Переменная в которой находится спрайт на щит
    public Text scoreText; // Текст количества монет
    public GameObject PanelLost; // Панель после смерти игрока
    public static bool lose = false; // Проигрыш
    public static bool pause; // Пауза
    public AudioClip CoinSound; // Звук подбора монеты
    public AudioClip ShieldSound; // Звук подбора щита
    public GameObject shield; // объект щита

    // Private Variable
    private bool immortal; // Аура неуязвимости
    public static bool magneto;
    [SerializeField] float moveSpeed = 5f;
    
    void Awake()
    {
        lose = false;
        pause = false;
        magneto = false;
    }

    void Start ()
    {
        score = 0;
        SetScoreText();
        PanelLost.SetActive(false);
    }

    public void PauseButtonClick()
    {
        pause =! pause;
        pausePanel.SetActive(pause);

    } 

	void OnTriggerEnter2D (Collider2D other) {

        
		if (other.gameObject.CompareTag("Bomb") && !immortal) //Если Попала бомба и не взят щит
        {
            other.gameObject.GetComponent<FallDown>().Exploud (); // Активация анимации взрыва
            lose = true;// Конец игры
            PanelLost.SetActive(true); //ЗАпуск панели паузы

            if (PlayerPrefs.GetString ("Music") == "no")
                PanelLost.GetComponent <AudioSource> ().mute = true;

            PlayerPrefs.SetInt("LastPoint", score); // Сохраняет последний рекорд сбора монет
		}

        if (other.tag == "coin")
        {
            score = score + 1;
            SetScoreText();
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint (CoinSound, transform.position);
        }

        if (other.tag == "Shield")
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(ShieldSound, transform.position);
            StopCoroutine(ShieldTimer()); // Отключен метод который дает неуязвимость
            StartCoroutine(ShieldTimer()); // Подключен метод который дает неуязвимость
        }

        if (other.tag == "Magnet")
        {
            Destroy(other.gameObject);
            StartCoroutine(MagnetTimer());
            StopCoroutine(MagnetTimer());
        }
    }

    private IEnumerator MagnetTimer ()
    {
        magneto = true;
        yield return new WaitForSeconds(20f);
        magneto = false;
    }

    private IEnumerator ShieldTimer() // Метод дающий неуязвимость во время действия щита
    {
        immortal = true;
        aura.enabled = immortal; // Включает спрайт(щит) при взятии щита
        yield return new WaitForSeconds(5.0f); // неуязвимость на 5 секунд
        immortal = false;
        aura.enabled = immortal;

    }


    public void SetScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
