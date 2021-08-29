using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMobs : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer[] _lineOne;
    [SerializeField]
    private SpriteRenderer[] _lineTwo;

    [SerializeField]
    private LevelImageNumberData _levelImageNumberData;

    [SerializeField]
    private MobsImageData _mobsImageData;

    [SerializeField]
    private GameObject _objExplosion;

    public void StartLevel(int level, int miniLvl)
    {
        for (int i = 0; i < _lineOne.Length; i++)
        {
            _lineOne[i].sprite = _mobsImageData.ImageMobs[level].MobsImage[_levelImageNumberData.ImageNumber[miniLvl].ImageNumber[0]];
            _lineTwo[i].sprite = _mobsImageData.ImageMobs[level].MobsImage[_levelImageNumberData.ImageNumber[miniLvl].ImageNumber[1]];
        }

        _objExplosion.GetComponent<ExplosionController>().SetImageExplosion(_mobsImageData.ImageMobs[level].MobDieSprite);

        EnemysGroupController.Instance.RefreshAliens();
    }

    public bool NextOrEnd(int lvl)
    {
        if (_mobsImageData.ImageMobs.Length <= (lvl + 1))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
