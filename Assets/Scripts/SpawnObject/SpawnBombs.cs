using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {

	public GameObject bomb;
    public CircleCollider2D BombColl;

    private void Awake()
    {
        BombColl = GetComponent<CircleCollider2D>();
    }

    void Start () {
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn () {
		while (!Player.lose) {
			Instantiate (bomb, new Vector2 (Random.Range (-2.85f, 2.85f), 5.521f), Quaternion.identity);
			yield return new WaitForSeconds (0.8f);
		}
        
	}
}
