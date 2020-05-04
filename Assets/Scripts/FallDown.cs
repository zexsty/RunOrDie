using UnityEngine;

public class FallDown : MonoBehaviour {

	[SerializeField]
	private float fallSpeed = 3f;

    public Explosion Explosion;

    void Update () {
		if (transform.position.y < -6f)// Уничтожение обьекта бомы за границами экрана
			Destroy (gameObject);

		transform.position -= new Vector3 (0, fallSpeed * Time.deltaTime, 0);
	}
    public void Exploud() {
        Explosion.gameObject.SetActive(true);
    }

}
