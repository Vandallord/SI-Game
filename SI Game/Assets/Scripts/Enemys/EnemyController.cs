using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour, ITakeHit
{   
    [SerializeField]
    private GameObject _effectDieEnemy;

    [SerializeField]
    private int _scoreValue = 100;

    [SerializeField]
    private int _healthEnemy = 1;

    public void TakeHit(int dmg = 1)
    {
        _healthEnemy -= dmg;

        if (_healthEnemy <= 0)
        {
            SoundManager.Instance.PlaySound("explosion");
            Instantiate(_effectDieEnemy, transform.position, transform.rotation);
            EnemysController.Instance.EnemyDeath(_scoreValue);
            EnemysGroupController.Instance.KillAlien(gameObject);
            GameController.Instance.WinCheck();
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Protection")
        {
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Player")
        {
            GameController.Instance.LoseGame();
           // Destroy(collision.gameObject);
        }
    }
}
