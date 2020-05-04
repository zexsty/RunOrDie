using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {
	public float moneti;

	// Use this for initialization
	void Start () {
		moneti = 50f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown () {
		if (Input.GetMouseButtonDown (0)) 
		{
			
			moneti -= 50f;
		
	}
}
}