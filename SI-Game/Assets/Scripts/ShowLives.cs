using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLives : MonoBehaviour
{
    public static ShowLives Instance;

    [SerializeField]
    private GameObject[] _lives;

    [SerializeField]
    private Transform _lives_;

    void Awake()
    {
        Instance = this;
    }

    public void ShowCurLives(int lives)
    {
        for (int i = 0; i < _lives.Length; i++)
        {
            if (lives > i)
            {
                _lives[i].SetActive(true);
            }
            else
            {
                _lives[i].SetActive(false);
            }
        }
    }
}
