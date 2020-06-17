using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{
    public GameObject Rocket;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!PlayerController.lose)
        {
            yield return new WaitForSeconds(Random.Range(5f, 12f));
            Instantiate(Rocket, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity);
        }
        
    }

}
