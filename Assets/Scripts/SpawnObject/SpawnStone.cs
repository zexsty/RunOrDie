using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    public GameObject Stone; // Объект Который будет спавнится 
    public BoxCollider2D StoneColl; // Коллайдер, если объекту нужно действие при косании с чем либо

    private void Awake()
    {
        StoneColl = GetComponent<BoxCollider2D>(); // Добавление компонента коллайдера на обьект
    }

    void Start()
    {
       StartCoroutine(Spawn()); // пристарте запускается метод спавна Объектов
    }

    IEnumerator Spawn() // Метод спавна объектов
    {
        while (!Player.lose) // Цикл который выполняется пока игрок жив
        {
            yield return new WaitForSeconds(Random.Range(10f, 60f)); // Задержка перед спавном объектов
            Instantiate(Stone, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity); // Первое - Это объект который будет спавнится, Второе - это это рандомное положение спавна(Координата от и до)
        }

    }
}
