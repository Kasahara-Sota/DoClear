using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int _redCount;
    public int _greenCount;
    public int _blueCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log($"R:{_redCount} G:{_greenCount} B:{_blueCount}");
        }
    }
}
