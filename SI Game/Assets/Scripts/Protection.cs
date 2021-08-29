using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protection : MonoBehaviour, ITakeHit
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private int _maxHealth = 3;
    private int _health;
    private Color _color;

    void Start()
    {
        _health = _maxHealth;
    }

    public void TakeHit(int dmg = 1)
    {
        _health -= dmg;
       // Debug.Log(_health);
        _color = _spriteRenderer.color;
        _spriteRenderer.color = Color.Lerp(_color, Color.black, 0.3f);
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
