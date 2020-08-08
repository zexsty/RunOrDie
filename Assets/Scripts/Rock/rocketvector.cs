using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketvector : MonoBehaviour
{
    public GameObject[] bomb;
    public GameObject player;
    public float speed;
    private float temp = 9999;
    private GameObject nearest = null;
    private float time = 0.8f;


    void Update()
    {
        bomb = GameObject.FindGameObjectsWithTag("Bomb");//запись в массив через тег
        if (bomb == null)
        {
            Destroy(gameObject);
        }
        if (time < 0)
        {
            Destroy(gameObject);
        }
        time -= Time.deltaTime;

        if (bomb == null)
        {
            Destroy(gameObject);
        }
        foreach (GameObject go in bomb)
        {
            float tmp2 = Vector3.Distance(transform.position, go.transform.position);
            if (tmp2 < temp)
            {
                temp = tmp2;
                nearest = go;
            }//поиск ближайшей бомбы
        }
        transform.position = Vector2.MoveTowards(transform.position, nearest.transform.position, speed * Time.deltaTime);//перемещение к ближайшей бомбе
        if (nearest == null)//если цель уже разрушена то и ракета удаляется
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bomb")
        {
            Destroy(gameObject);
        }
    }
}