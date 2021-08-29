using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
       
    [SerializeField]
    private int _level;
    [SerializeField]
    private int _miniLevel;
    private Vector2 _aliensTrasform = new Vector2(0, 1.12f);
    [SerializeField]
    private ImageMobs _imageMobs;
    [SerializeField]
    private GameObject _aliens;

    void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        //_level = 0;
        //_miniLevel = 0;

        LoadLevel();
    }

    public void NextLevel()
    {
        _miniLevel++;

        if (_miniLevel > 3)
        {
            _level++;
            _miniLevel = 0;
        }

        LoadLevel();
    }

    private void LoadLevel()
    {
        _imageMobs.StartLevel(_level, _miniLevel);
        CanvasTextController.Instance.LevelShow(_level, _miniLevel);

        for (int i = 0; i < _aliens.transform.childCount; i++)
        {
            _aliens.transform.GetChild(i).gameObject.SetActive(true);
        }

        _aliens.transform.position = _aliensTrasform;
    }

    public bool NextOrEnd() 
    {
        return _imageMobs.NextOrEnd(_level);
    }
}
