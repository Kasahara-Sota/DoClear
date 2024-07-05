using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool _isInput;
    public bool _isTimeUp;
    [SerializeField] Text _scoreText;
    [SerializeField] Text _timerText;
    private float _timer = 60f;
    [SerializeField] ScoreManager _ScoreManager;
    void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer < 0)
        {
            _timer = 0;
            _isTimeUp = true;
        }
            
        if(_isInput)
        {
            _scoreText.text = "SCORE:" + _ScoreManager._colorScore.ToString();
            _timerText.text = _timer.ToString("F2");
        }
        if(_ScoreManager._redCount >= 1 && _ScoreManager._redCount == _ScoreManager._redCount + _ScoreManager._greenCount + _ScoreManager._blueCount)
            _scoreText.color = Color.red;
        else
            _scoreText.color = Color.black;
    }
}
