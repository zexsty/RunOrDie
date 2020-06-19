using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPlanet : MonoBehaviour
{
    public Transform rotateObj;
    public Transform aroundObj;
    public float rotSpeed = 5f;
    void Update()
    {
        Rotator();
    }
    void Rotator()
    {
        rotateObj.RotateAround(aroundObj.position, new Vector3(0, 0, -1), rotSpeed);
    }
}
