using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysGroupController : MonoBehaviour
{
    public static EnemysGroupController Instance;

    [SerializeField]
    private GameObject[] _aliensGroup;

    private List<GameObject> _aliensLifeGroup = new List<GameObject>();

    void Awake()
    {
        Instance = this;
    }

    public GameObject GetOneAlein()
    {
        return _aliensLifeGroup[Random.Range(0, _aliensLifeGroup.Count)];
    }

    public bool AllMobsKill()
    {
        if (_aliensLifeGroup.Count == 0)
        {
            return true;
        }

        return false;
    }

    public void KillAlien(GameObject asd)
    {
        _aliensLifeGroup.Remove(asd);
    }

    public void RefreshAliens()
    {
        _aliensLifeGroup.Clear();

        foreach (var item in _aliensGroup)
        {
            _aliensLifeGroup.Add(item);
        }
    }
}
