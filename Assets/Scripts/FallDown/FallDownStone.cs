using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownStone : MonoBehaviour
{
    public bool isGround;
    public GameObject partycle;

    void Update()
    {
        if (isGround)
        {
            partycle.SetActive(true);
        }
        if (transform.position.y < 2.0f)// Уничтожение обьекта бомы за границами экрана
            Destroy(gameObject, 5f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGround = true;
        }
    }
}
