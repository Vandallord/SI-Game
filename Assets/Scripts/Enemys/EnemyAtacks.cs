using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtacks : MonoBehaviour
{

    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private float _chanceOfAttack = 0.02f;

    public void AttackEnemy(Transform enemy)
    {
        if (Random.value < _chanceOfAttack)
        {
            if (!EnemysGroupController.Instance.AllMobsKill())
            {
                Instantiate(_bullet, EnemysGroupController.Instance.GetOneAlein().transform.position, enemy.rotation);
            }
        }
    }
}
