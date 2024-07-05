using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool IsInput;
    public bool IsTimeUp;
    [SerializeField] Text _scoreText;
    [SerializeField] Text _timerText;
    private float _timer = 60f;
    [SerializeField] int _redPoint;
    [SerializeField] int _greenPoint;
    [SerializeField] int _bluePoint;
    private int _redCount;
    private int _greenCount;
    private int _blueCount;
    private int _colorScore;
    private int _bottunDownedCount;
    private bool _isScoreClear;
    private bool _isBottunDownedClear;
    private bool _isRedClear;
    private bool _isTimeUpClear;
    void FixedUpdate()
    {
        _colorScore = _redCount * _redPoint + _greenCount * _greenPoint + _blueCount * _bluePoint;
        _timer -= Time.deltaTime;
        if (_timer < 0)
        {
            _timer = 0;
            IsTimeUp = true;
            if(_colorScore >= 300)
                _isScoreClear = true;
            if(_bottunDownedCount >= 3000)
                _isBottunDownedClear = true;
            if(_redCount>30 && _scoreText.color == Color.red)
                _isRedClear = true;
            if(!IsInput)
                _isTimeUpClear = true;
        }
            
        if(IsInput)
        {
            _scoreText.text = "SCORE:" + _colorScore.ToString();
            _timerText.text = _timer.ToString("F2");
        }
        if(_redCount >= 1 && _redCount == _redCount + _greenCount + _blueCount)
            _scoreText.color = Color.red;
        else
            _scoreText.color = Color.black;
        
    }
    
    

    public void AddRedCount(int count)
    {
        _redCount += count;
    }
    public void AddGreenCount(int count)
    {
        _greenCount += count;
    }
    public void AddBlueCount(int count)
    {
        _blueCount += count;
    }
    public void AddBottunDownedCount()
    {
        _bottunDownedCount++;
        Debug.Log(_bottunDownedCount/2);
    }
}
