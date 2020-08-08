using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public GameObject rockets;
    static public bool rocketscore = false;
    public GameObject player;
    public Vector3 lol;
    public bool prov;
    public float time;

    void Start()
    {
        lol = new Vector3(1f, 0f, 0);
    }


    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (rocketscore)
        {

            Instantiate(rockets, player.transform.position, Quaternion.identity);
            prov = true;
            time = 0.7f;
            rocketscore = false;
        }
        if (prov && time < 0)
        {
            Instantiate(rockets, player.transform.position, Quaternion.identity);
            prov = false;
        }
        time -= Time.deltaTime;
    }

}
