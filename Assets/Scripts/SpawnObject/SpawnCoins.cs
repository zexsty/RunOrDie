﻿using System.Collections;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {

	public GameObject coin;
    private Transform _playerPoint;
    public float speed;
    private PlayerController magnet;

    void Start () {
        magnet = GetComponent<PlayerController>();
		StartCoroutine (Spawn ());
        PlayerController.magneto = magnet;
        _playerPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (magnet)
        {
            transform.position = Vector3.MoveTowards(transform.position, _playerPoint.position, speed * Time.deltaTime);
        }
    }

    IEnumerator Spawn () {
		while (!PlayerController.lose) {
            yield return new WaitForSeconds(Random.Range(3.0f, 5.0f));
            Instantiate (coin, new Vector2 (Random.Range (-2.85f, 2.85f), 5.521f), Quaternion.identity);
		}
	}

}
