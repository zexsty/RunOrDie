using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownStone : MonoBehaviour
{

    [SerializeField]
    private float fallSpeed;

    void Update()
    {
        if (transform.position.y < 2.0f)// Уничтожение обьекта бомы за границами экрана
            Destroy(gameObject, 5f);

        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
