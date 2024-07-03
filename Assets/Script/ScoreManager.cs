using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int _redPoint;
    [SerializeField] int _greenPoint;
    [SerializeField] int _bluePoint;
    public int _redCount;
    public int _greenCount;
    public int _blueCount;
    public int _colorScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log($"R:{_redCount} G:{_greenCount} B:{_blueCount}");
            _colorScore = _redCount * _redPoint + _greenCount * _greenPoint + _blueCount * _bluePoint;
            Debug.Log(_colorScore);
        }
        
    }
}
