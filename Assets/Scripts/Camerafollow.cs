using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float _minX = -48f;
    [SerializeField]
    private float _maxX = 48f;


    private void LateUpdate()
    {
        if (player == null)
            return;

        Vector3 _tempPos = transform.position;

        _tempPos.x =player.position.x;

        if (_tempPos.x >= _maxX)
        {
             _tempPos.x = _maxX;

        }
        if (_tempPos.x <= _minX)
        {
             _tempPos.x = _minX;

        }

        transform.position = _tempPos;

    } //LateUpdate

}//class
