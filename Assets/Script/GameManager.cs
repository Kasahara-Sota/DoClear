using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool _isInput;
    [SerializeField] Text _scoreText;
    [SerializeField] Text _timerText;
    private float _timer = 60f;
    [SerializeField] ScoreManager _ScoreManager;
    void Update()
    {
        _timer -= Time.deltaTime;
        if(_isInput)
        {
            _scoreText.text = _ScoreManager._colorScore.ToString();
            _timerText.text = _timer.ToString("F2");
        }
        
    }
}
