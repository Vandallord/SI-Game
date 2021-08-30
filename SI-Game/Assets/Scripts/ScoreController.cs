using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public static ScoreController Instance;

    private int _currentScore;

    [SerializeField]
    private bool _resetScoreOnStart;

    private bool _isScoreAdderRunning;

    void Awake()
    {
        Instance = this;
    }

    public void LoadScore()
    {
        if (_resetScoreOnStart)
        {
            PlayerPrefs.SetInt("CurrentScore", 0);
        }
        _currentScore = PlayerPrefs.GetInt("CurrentScore", 10);

        _isScoreAdderRunning = false;
    }

    public IEnumerator AddScoreOverTime(int value)
    {
        _isScoreAdderRunning = true;
        int addedScore = 0;
        while (addedScore < value)
        {
            RefreshCurScore(100);
            addedScore += 100;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void RefreshCurScore(int value)
    {
        _currentScore += value;
        CanvasTextController.Instance.RefreshScore(_currentScore);
    }

    public bool GetIsScoreAdderRunning()
    {
        return _isScoreAdderRunning;
    }    
}
