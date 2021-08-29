using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResp : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private Vector2 _respPos = new Vector2(-0.03f, -3.46f);

    public void RespPlayer()
    {
        _player.SetActive(true);
        _player.transform.position = _respPos;
        _player.GetComponent<PlayerHealth>().RefreshHealth();
        _player.GetComponent<PlayerShooting>().StartShooting();
    }
}
