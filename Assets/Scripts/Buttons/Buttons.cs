using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public GameObject m_on, m_off;
	public Sprite layer_blue, layer_red;

	void Start () {
		if (gameObject.name == "Music") {
			if (PlayerPrefs.GetString ("Music") == "no") {
				m_on.SetActive (false);
				m_off.SetActive (true);
			} else {
				m_on.SetActive (true);
				m_off.SetActive (false);
			}
		}
	}

	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUpAsButton () {

		switch (tag) {
		case "Play":
			Application.LoadLevel ("Level_1");
			break;
		case "Replay":
			Application.LoadLevel ("Level_1");
			break;
		case "Home":
			Application.LoadLevel ("MainMenu");
			break;
		case "Music":
			if (PlayerPrefs.GetString ("Music") != "no") {
				PlayerPrefs.SetString ("Music", "no");
				m_on.SetActive (false);
				m_off.SetActive (true);
			} else {
				PlayerPrefs.SetString ("Music", "yes");
				m_on.SetActive (true);
				m_off.SetActive (false);
			}
			break;
		case "Next":
			Application.LoadLevel ("Level_2");
			break;
		//case "Shop":
		//	Application.LoadLevel ("Shop");
		//	break;
	//	case "Close":
		//	Application.LoadLevel ("MainMenu");
		//	break;
		//case "ArrowRight":
		//	Application.LoadLevel ("Shop 1");
	//		break;
	//	case "ArrowLeft":
		//	Application.LoadLevel ("Shop");
		//	break;
		}
	}
}
