using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Record : MonoBehaviour {

	void Start () {
		GetComponent <Text> ().text = PlayerPrefs.GetInt ("SaveScore").ToString ();
	}

}
