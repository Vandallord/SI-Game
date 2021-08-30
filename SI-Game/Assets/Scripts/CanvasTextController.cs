using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTextController : MonoBehaviour
{
    public static CanvasTextController Instance;

    [SerializeField]
    private Text _scoreText;

    [SerializeField]
    private Text _healthText;

    [SerializeField]
    private Text _winOrLoseText;

    [SerializeField]
    private Text _levelShow;

    void Awake()
    {
        Instance = this;
    }

    public void HealthUpdate(int health, int maxHealth)
    {
        ShowLives.Instance.ShowCurLives(health);
        //_healthText.text = string.Format("Lives {0}/{1}", health, maxHealth);
    }

    public void RefreshScore(int score)
    {
        _scoreText.text = string.Format("Score: {0}", score);
        // _scoreText.text = string.Format("Current: {0} \n Total: {1}", score, hiscore);
    }

    public void Win()
    {
        _winOrLoseText.text = "Victory";
    }

    public void Lose()
    {
        _winOrLoseText.text = "Game Over";
    }

    public void HideWinGame()
    {
        _winOrLoseText.text = "";
    }

    public void LevelShow(int level, int miniLevel)
    {
        _levelShow.text = level + "-" + miniLevel + " Level";
    }

    internal void WinGame()
    {
        _winOrLoseText.text = "You completed the game";
    }
}
