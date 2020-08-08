using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnrocket : MonoBehaviour
{

    public GameObject rock;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!PlayerController.lose)
        {
            yield return new WaitForSeconds(Random.Range(5f, 10f));
            Instantiate(rock, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity);
        }

    }
}