using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    SpriteRenderer _circleColor;
    // Start is called before the first frame update
    void Start()
    {
        _circleColor = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (_circleColor.color.r != 0 )
        {

        }
        else if(_circleColor.color.g != 0)
        {

        }
        else
        {

        }
        Destroy(this.gameObject);
    }
}
