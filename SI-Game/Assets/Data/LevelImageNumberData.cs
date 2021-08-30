using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelImageNumberData", menuName = "LevelImageNumberData", order = 53)]
public class LevelImageNumberData : ScriptableObject
{
    public LevelImageNumber[] ImageNumber;

    [Serializable]
    public class LevelImageNumber
    {
        public byte[] ImageNumber;
        public bool LineOrTwo; 
    }
}
