using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantinateStar : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnStars;
    private GameObject _spawn;

    private void Start()
    {
        StartCoroutine(SpawnStar());
    }

    private IEnumerator SpawnStar()
    {
        while (!PlayerController.lose)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, 1f));
            _spawn = Instantiate(_spawnStars[Random.Range(0, 4)], new Vector2(Random.Range(-2.85f, 2.85f), Random.Range(0.1f, 5.0f)), Quaternion.identity);
            GameObject.Destroy(_spawn, 5f);
        }
    }
}
