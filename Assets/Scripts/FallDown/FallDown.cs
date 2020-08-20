using UnityEngine;

public class FallDown : MonoBehaviour {

	[SerializeField]
	private float fallSpeed = 3f; // Скорость падения объекта

    public Explosion Explosion; // Анимация взрыва для бомбы

    void Update () {
		if (transform.position.y < -2.7f)// Уничтожение обьекта бомы за границами экрана
			Destroy (gameObject); // Когда объект по координате "Y" -6f то объект будет уничтожен

		transform.position -= new Vector3 (0, fallSpeed * Time.deltaTime, 0);// Объект будет лететь только по координате Y
		if (transform.position.y < 0)
		{
			gameObject.tag = "stbomb";
		}
	}
    public void Exploud() {
        Explosion.gameObject.SetActive(true);// Включается анимация взрыва после прикосновения с игроком
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Rocket")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);

		}

	}
		}
