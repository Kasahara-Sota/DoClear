using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GenerateDir
{
    right,
    left
}
public class Generate : MonoBehaviour
{
    [SerializeField] GameObject[] _prehubs;

    private Vector2 _position;
    private GameObject _obj;
    private Rigidbody2D _rb;
    private Vector2 _vec;
    private int _power;
    
    [SerializeField] GenerateDir _dir;
    [SerializeField]GameManager _gameManager;
    void Start()
    {
        _position = transform.position;
    }


    void Update()
    {
        if (Input.anyKeyDown)
        {
            _gameManager._isInput = true;
            _obj = Instantiate(_prehubs[Random.Range(0, 3)], _position, Quaternion.identity) as GameObject;
            _rb = _obj.GetComponent<Rigidbody2D>();
            _vec.x = Random.Range(5, 10);
            if (_dir == GenerateDir.left)
                _vec.x *= -1;
            _vec.y = Random.Range(5, 10);
            _power = Random.Range(5, 15);
            _rb.AddForce(_vec.normalized * _power, ForceMode2D.Impulse);
        }

    }
}
