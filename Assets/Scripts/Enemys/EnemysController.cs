using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysController : MonoBehaviour
{
    public static EnemysController Instance;

    [SerializeField]
    private float _waitEnemys = 4f;
    [SerializeField]
    private float _speedMultiplier = 0.01f;
    [SerializeField]
    private float _speedEnemy = 0.45f;
    [SerializeField]
    private bool _reversal = false;

    [SerializeField]
    private float _boundLeft = 9f;
    [SerializeField]
    private float _boundRight = 9f;

    [SerializeField]
    private Transform _transformObj;

    [SerializeField]
    private EnemyAtacks _enemyAtacks;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        StartCoroutine(EnemyLoopAttack());
        //   InvokeRepeating("EnemyLoopAttack", 0, _waitAliens);
    }

    private IEnumerator EnemyLoopAttack()
    {
        while (true)
        {
            refresh:

            yield return new WaitForSeconds(_waitEnemys);


            if (!_reversal)
            {
                _transformObj.position +=  _speedEnemy * Vector3.right;
            }
            else
            {
                _speedEnemy *= -1;
                _transformObj.position += Mathf.Abs(_speedEnemy) * Vector3.down;
                _reversal = false;
                goto refresh;
            }

            foreach (Transform enemy in _transformObj)
            {
                // поворот
                if (enemy.position.x < -_boundLeft)
                {
                    _reversal = true;
                    break;
                }
                else if (enemy.position.x > _boundRight)
                {
                    _reversal = true;
                    break;
                }

                // атака захватчиков
                _enemyAtacks.AttackEnemy(enemy);
            }
        }
    }

    public void EnemyDeath(int value)
    {
        ScoreController.Instance.RefreshCurScore(value);
        if (_speedEnemy > 0)
        {
            _speedEnemy = _speedEnemy + _speedMultiplier;
        }
        else
        {
            _speedEnemy = _speedEnemy - _speedMultiplier;
        }
    }
}
