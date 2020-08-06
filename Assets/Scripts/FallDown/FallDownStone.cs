using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownStone : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y < 2.0f)// Уничтожение обьекта бомы за границами экрана
            Destroy(gameObject, 55f);
    }

}
