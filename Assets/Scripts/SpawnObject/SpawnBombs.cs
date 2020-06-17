using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {

    public GameObject bomb;
    public CircleCollider2D BombColl;
    
    [SerializeField]
    private GameObject _coins;

    private void Awake()
    {
        BombColl = GetComponent<CircleCollider2D>();
    }

    void Start () {
        StartCoroutine (Spawn ());
    }

	IEnumerator Spawn () {
		while (!PlayerController.lose) {
            if (PlayerController.SwapCoin == false)
            {
                Instantiate(bomb, new Vector2(Random.Range(-3.5f, 3.2f), 5.521f), Quaternion.identity);
                yield return new WaitForSeconds(0.8f);
            }
            else if (PlayerController.SwapCoin == true)
            {
                Instantiate(_coins, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity);
                yield return new WaitForSeconds(0.2f);
            }
		}
        
	}
}
