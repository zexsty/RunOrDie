using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsMainFon : MonoBehaviour
{
    [SerializeField] private List<GameObject> _stars;
    private GameObject _insStars;

    void Start()
    {
        StartCoroutine(SpawnStarFon());
    }

    private IEnumerator SpawnStarFon()
    {
        while (!PlayerController.lose)
        {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
          _insStars =  Instantiate(_stars[Random.Range(0, 2)], new Vector2(Random.Range(-2.85f, 2.85f), Random.Range(0.1f, 5.0f)), Quaternion.identity);
            GameObject.Destroy(_insStars, 5f);
        }
        
    }
}

