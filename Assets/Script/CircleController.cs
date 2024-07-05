using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class CircleController : MonoBehaviour
{    
    SpriteRenderer _circleColor;
    GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _circleColor = this.GetComponent<SpriteRenderer>();
        _gameManager = FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!_gameManager.IsTimeUp)
        {
            if (_circleColor.color.r != 0)
            {
                _gameManager.AddRedCount(1);
            }
            else if (_circleColor.color.g != 0)
            {
                _gameManager.AddGreenCount(1);
            }
            else
            {
                _gameManager.AddBlueCount(1);
            }
            Destroy(this.gameObject);
        }
    }
}
