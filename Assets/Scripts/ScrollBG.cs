using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    public float _speedBG = -0.05f;
    [SerializeField] private Vector2 _offset;

    void LateUpdate()//fixed
    {
        _offset = new Vector2(0, Time.time * _speedBG);
        GetComponent<Renderer>().material.mainTextureOffset = _offset;
    }
}
