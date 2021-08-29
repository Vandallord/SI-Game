using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour, ITakeHit
{
    [SerializeField]
    private float _speedBullet = 4.5f;

   private void Update()
    {
       transform.position += _speedBullet * Time.deltaTime * Vector3.down; 
    }

    public void TakeHit(int dmg = 1)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Enemy")
        {
            collision.gameObject.GetComponent<ITakeHit>().TakeHit();
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}