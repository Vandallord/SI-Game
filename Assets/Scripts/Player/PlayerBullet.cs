using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour, ITakeHit
{
    [SerializeField]
    private float _speedBullet = 4.4f;

    void Update()
    {
        transform.position += Time.deltaTime * Vector3.up * _speedBullet;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void TakeHit(int dmg = 1)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<ITakeHit>().TakeHit();
        Destroy(gameObject);
    }
}