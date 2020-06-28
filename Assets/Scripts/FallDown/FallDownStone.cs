using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownStone : MonoBehaviour
{
    public GameObject PanelLost;
    [SerializeField] private GameObject _player;
    private PlayerController _panelLost;

    void Update()
    {
        if (transform.position.y < 2.0f)// Уничтожение обьекта бомы за границами экрана
            Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Hat")
        {
            PanelLost.SetActive(true);
            PlayerController.lose = true;
            _player.SetActive(false);
        }
    }
}
