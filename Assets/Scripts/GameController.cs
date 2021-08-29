using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    [SerializeField]
    private PlayerResp _playerResp;

    [SerializeField]
    private GameObject _enemys;
    [SerializeField]
    private GameObject _player;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        LevelManager.Instance.StartGame();
        _playerResp.RespPlayer();
        ScoreController.Instance.LoadScore();
    }

    public void WinCheck()
    {
        if (EnemysGroupController.Instance.AllMobsKill())
        {
            if (!ScoreController.Instance.GetIsScoreAdderRunning())
            {
                StartCoroutine(ScoreController.Instance.AddScoreOverTime(2000));
            }

            if (LevelManager.Instance.NextOrEnd()) // проверка непрошли ли игру
            {
                StartCoroutine(NextLevel());
            }
            else
            {
                StartCoroutine(WinGame());
            }
        }

        if (_enemys.transform.position.y <= -5)
        {
            _player.SetActive(false);
        }
    }

    public void LoseGame()
    {
        StartCoroutine(LoseScene());
    }

    //в уровни
    private IEnumerator NextLevel()
    {
        CanvasTextController.Instance.Win();
        yield return new WaitForSeconds(6f);
        CanvasTextController.Instance.HideWinGame();

        LevelManager.Instance.NextLevel();
    }

    private IEnumerator LoseScene()
    {
        CanvasTextController.Instance.Lose();
        yield return new WaitForSeconds(4f);
        CanvasTextController.Instance.HideWinGame();

        LevelManager.Instance.StartGame();
        _playerResp.RespPlayer();
    }

    private IEnumerator WinGame()
    {
        CanvasTextController.Instance.WinGame();
        yield return new WaitForSeconds(4f);
        CanvasTextController.Instance.HideWinGame();

        LevelManager.Instance.StartGame();
        _playerResp.RespPlayer();
    }
}
