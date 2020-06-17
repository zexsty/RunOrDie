using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class RocketSpawnShot : MonoBehaviour
{
    /** private float _shotSpeed = 5f;
     private Transform _player;
     private Transform _bombPoint;
     [SerializeField]
     private GameObject _rocketObject;
     private float _spawnTime = 3f;

     void Start()
     {
         _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
         _bombPoint = GameObject.FindGameObjectWithTag("Bomb").GetComponent<Transform>();
         InvokeRepeating("Update", 0, _spawnTime);
     }

     void Update()
     {
         if (Player.rocket)
         {
             GameObject RocketPrefab = Instantiate( _rocketObject, _player.position, Quaternion.identity);
             transform.position = Vector3.MoveTowards(_player.position, _bombPoint.position, _shotSpeed);
         }
     }
     **/
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _detonationRange = 0.5f;
    private Transform _transform;
    private Transform _target;
    private bool _lounched;

    public void Lounch(Transform player, Transform target)
    {
        _transform = transform;
        _target = target;
        _lounched = true;
        _transform.position = player.position;
    }

    private void Detonation()
    {
        if (_target != null)
            _target.gameObject.AddComponent<FallDownRocket>();
        Destroy(gameObject);
    }

    private void Update()
    {
        if (_lounched)
        {
            if (_target != null)
            {
                _transform.position = Vector3.MoveTowards(_transform.position, _target.position, _speed * Time.deltaTime);
                _transform.LookAt(_target.position);
                if (Vector3.Distance(_transform.position, _target.position) < _detonationRange)
                    Detonation();
            }
            else
                Detonation();
        }
    }
}
