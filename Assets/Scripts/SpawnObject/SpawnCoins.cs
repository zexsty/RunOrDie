using System.Collections;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {

	public GameObject coin;

	void Start () {
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn () {
		while (!Player.lose) {
            yield return new WaitForSeconds(Random.Range(3.0f, 5.0f));
            Instantiate (coin, new Vector2 (Random.Range (-2.85f, 2.85f), 5.521f), Quaternion.identity);
		}
	}

}
