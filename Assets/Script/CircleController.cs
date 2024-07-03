using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    SpriteRenderer _circleColor;
    ScoreManager _scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        _circleColor = this.GetComponent<SpriteRenderer>();
        _scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (_circleColor.color.r != 0 )
        {
            _scoreManager._redCount++;
        }
        else if(_circleColor.color.g != 0)
        {
            _scoreManager._greenCount++;
        }
        else
        {
            _scoreManager._blueCount++;
        }
        Destroy(this.gameObject);
    }
}
