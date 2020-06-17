using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownCoints : MonoBehaviour
{
    [SerializeField]
    private float fallSpeedCoin = 3f; // Скорость падения объекта

    private Transform _playerPoint;

    void Start()
    {
        _playerPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (transform.position.y < -6f)// Уничтожение обьекта бомы за границами экрана
            Destroy(gameObject); // Когда объект по координате "Y" -6f то объект будет уничтожен

        transform.position -= new Vector3(0, fallSpeedCoin * Time.deltaTime, 0);// Объект будет лететь только по координате Y
 
        if (PlayerController.magneto)
        {
            transform.position = Vector3.MoveTowards(transform.position, _playerPoint.position, fallSpeedCoin * 0.05f);
        }

        if (PlayerController.SwapCoin == true)
        {
            fallSpeedCoin = 7f;
        }
    }
}
