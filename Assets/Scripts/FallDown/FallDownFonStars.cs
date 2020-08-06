using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownFonStars : MonoBehaviour
{
    private float FallSpeed = 5f;

    void Update()
    {
        if (transform.position.y < -6f)
            Destroy(gameObject);

        transform.position -= new Vector3(FallSpeed * Time.deltaTime, FallSpeed * Time.deltaTime, 0);
    }
}
