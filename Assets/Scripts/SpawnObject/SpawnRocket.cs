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
        while (!Player.lose)
        {
            yield return new WaitForSeconds(Random.Range(50f, 120f));
            Instantiate(Rocket, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity);
        }
        
    }

}
