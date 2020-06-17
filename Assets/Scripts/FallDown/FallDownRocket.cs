using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class FallDownRocket : MonoBehaviour
{
    /**
    [SerializeField]
    private float fallSpeed = 3f; // Скорость падения объекта

    void Update()
    {
        if (transform.position.y < -6f){// Уничтожение обьекта бомы за границами экрана
            Destroy(gameObject); } // Когда объект по координате "Y" -6f то объект будет уничтожен

        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);// Объект будет лететь только по координате Y
    }
    **/
    private float _speed = -3f;
    private float _destroyY = -6f;
    private Transform _transform;

    private void Start()
    {
        _transform = transform;
    }

    void Update()
    {
        _transform.position += new Vector3(0, _speed, 0) * Time.deltaTime;
        if (_transform.position.y < _destroyY)
            Destroy(gameObject);
    }

}
