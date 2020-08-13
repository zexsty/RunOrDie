using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownStar : MonoBehaviour
{
    private float FallSpeed = 2f;
 
 
    void Update()
    {

      
        if (transform.position.y < - 6f)
             Destroy(gameObject);

            transform.position -= new Vector3(0, FallSpeed * Time.deltaTime, 0); 
    }
  
}
