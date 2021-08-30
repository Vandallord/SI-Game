using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _imageExplosion;

    void Start()
    {
        StartCoroutine(ExplosionCoroutine());
    }

    IEnumerator ExplosionCoroutine()
    {
        yield return new WaitForSeconds(1);

        Destroy(gameObject);
    }

   public void SetImageExplosion(Sprite sprite)
    {
        _imageExplosion.sprite = sprite;
    }
}
