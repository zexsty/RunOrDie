using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatCollider : MonoBehaviour
{
    public GameObject PanelLost;
    [SerializeField] private GameObject _player;
    private PlayerController _panelLost;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Stone")
        {
            PanelLost.SetActive(true);
            PlayerController.lose = true;
            _player.SetActive(false);
        }
    }
}
