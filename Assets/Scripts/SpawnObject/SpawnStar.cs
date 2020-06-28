using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStar : MonoBehaviour
{
    public GameObject StarPrefab;
    void Start()
    {
        StartCoroutine(SpawnStarObject());
    }

    IEnumerator SpawnStarObject() {
        while (!PlayerController.lose) {
            yield return new WaitForSeconds(Random.Range(60f, 160f));
            Instantiate(StarPrefab, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity);
        }
    }

}
