using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MobsImageData", menuName = "MobsImageData", order = 53)]
public class MobsImageData : ScriptableObject
{
    public ImageMobsData[] ImageMobs;

    [Serializable]
    public class ImageMobsData
    {
        public Sprite[] MobsImage;
        public Sprite MobDieSprite;
        //    public Sprite BossImage;
        //    public Sprite BossDie;
    }
}
