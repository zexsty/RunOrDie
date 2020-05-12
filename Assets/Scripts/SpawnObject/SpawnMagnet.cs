using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMagnet : MonoBehaviour
{
    public GameObject Magnet;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() {
        while (!Player.lose)
        {
            yield return new WaitForSeconds(Random.Range(5f, 6f));
            Instantiate(Magnet, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity);
        }

    }

}
