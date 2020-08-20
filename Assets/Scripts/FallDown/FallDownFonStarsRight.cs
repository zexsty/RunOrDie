using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownFonStarsRight : MonoBehaviour
{
    private float FallSpeed;

    private void Start()
    {
        FallSpeed = (Random.Range(2f, 7f));
    }

    void Update()
    {
        if (transform.position.y < -6f)
            Destroy(gameObject);
        
        transform.position -= new Vector3(-FallSpeed * Time.deltaTime, FallSpeed* Time.deltaTime, 0);
    }
}
