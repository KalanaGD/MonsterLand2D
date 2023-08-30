using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D _rB;
    [HideInInspector]
    public float _speed;

    void Start()
    {
        _rB = GetComponent<Rigidbody2D>();

    }//Start

    void Update()
    {
        EnemyMove();

    }//Update

    private void EnemyMove()
    {
        _rB.velocity = new Vector2(_speed, _rB.velocity.y);

    }//EnemyMove

}//class
