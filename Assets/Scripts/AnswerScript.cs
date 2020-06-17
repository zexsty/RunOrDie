using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    [DisallowMultipleComponent]
    public class Player : MonoBehaviour
    {
        [SerializeField] [Tooltip("Require component \"Roket\"")] private GameObject _roketPrefub;

        private void OnValidate()
        {
            if (_roketPrefub != null && _roketPrefub.GetComponent<Roket>() == null)
            {
                _roketPrefub = null;
                Debug.LogError("\"Roket Prefub\" not contain \"Roket\" component");
            }
        }

        private void LaunchRoket(Transform target)
        {
            if (_roketPrefub != null)
            {
                GameObject NewRoket = Instantiate(_roketPrefub);
                Roket Roket = NewRoket.GetComponent<Roket>();
                Roket.Setup(transform, target);
            }
        }
    }

    [DisallowMultipleComponent]
    public class Roket : MonoBehaviour
    {
        [SerializeField] private float _lounchDelay = 3f;
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _detonationRange = 0.5f;
        private Transform _transform;
        private Transform _player;
        private Transform _target;
        private bool _lounched;

        public void Setup(Transform player, Transform target)
        {
            _transform = transform;
            _player = player;
            _target = target;
            _transform.position = new Vector3(1000, 1000, 1000);
            _lounched = false;
            Invoke("Lounch", _lounchDelay);
        }

        private void Lounch()
        {
            if (_player != null && _target != null)
            {
                _lounched = true;
                _transform.position = _player.position;
            }
            else
                Detonation();
        }

        private void Detonation()
        {
            if (_target != null)
                _target.gameObject.AddComponent<Fall>();
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

    [DisallowMultipleComponent]
    public class Fall : MonoBehaviour
    {
        private float _speed = -3f;
        private float _destroyY = -6f;
        private Transform _transform;

        private void Start()
        {
            _transform = transform;
        }

        void Update()
        {
            _transform.position += new Vector3(0, _speed, 0) * Time.deltaTime;
            if (_transform.position.y < _destroyY)
                Destroy(gameObject);
        }
    }
}
