using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private float _shootSpeed = 1f;

    [SerializeField]
    private Transform _targetShoot;

    public void StartShooting()
    {
        StartCoroutine(ShootingRoutine());
    }

    private IEnumerator ShootingRoutine()
    {
        while (true)
        {
            if (Input.GetButton("Fire1"))
            {
                SoundManager.Instance.PlaySound("laser");
                Instantiate(_bullet, _targetShoot.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(1f / _shootSpeed);
        }
    }
}
//Input.GetButton("Fire1") ^ Input.GetMouseButtonDown(0) ^ Input.GetKeyDown("space")
