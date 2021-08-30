using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _bounds = 0.59f;
    private Vector3 _screenSize;
    private Vector3 _mousePosition;

    private void Awake()
    {
        _screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    private void FixedUpdate()
    {
        _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(_mousePosition.x, transform.position.y, 0);

        if (transform.position.x > _screenSize.x - _bounds)
        {
            transform.position = new Vector3(_screenSize.x - _bounds, transform.position.y, 0);
        }
        else if (transform.position.x < -_screenSize.x + _bounds)
        {
            transform.position = new Vector3(-_screenSize.x + _bounds, transform.position.y, 0);
        }
    }
}
