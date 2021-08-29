using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, ITakeHit
{
    private int _health;
    public int _maxHealth = 4;
    
    public void RefreshHealth()
    {
        _health = _maxHealth;
        CanvasTextController.Instance.HealthUpdate(_health, _maxHealth);
    }

    public void TakeHit(int dmg = 1)
    { 
        _health -= dmg;

        CanvasTextController.Instance.HealthUpdate(_health, _maxHealth);

        if (_health <= 0)
        {
            GameController.Instance.LoseGame();
            gameObject.SetActive(false);
        }
    }
}
