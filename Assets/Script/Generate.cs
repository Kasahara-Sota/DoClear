using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    [SerializeField] GameObject[] _prehubs ;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        Instantiate(_prehubs[0]);
    }
}
