using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //movement
    private float _moveSpeed = 10f;
    private float _horizontalInput;
    //animations
    private SpriteRenderer _sR;
    private Animator _anim;
    //physics
    private Rigidbody2D _rB;
    private float _jumpForce = 15f;
    [SerializeField]
    private bool _isGrounded = false;

    [SerializeField]
    private GameObject _gameOverPanel;


    void Start()
    {
        _sR = GetComponent<SpriteRenderer>();
        _rB = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        
    }//Start

    void Update()
    {
        PlayerMovement();
        PlayerAnimation();
        PlayerJump();

    }//Update

    private void PlayerMovement()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(_horizontalInput, 0, 0) * Time.deltaTime * _moveSpeed;

    }//PlayerMovement

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& _isGrounded == true) 
        {
            _rB.AddForce(Vector2.up*_jumpForce, ForceMode2D.Impulse);
            _isGrounded = false;
        }

    }//PlayerJump

    private void PlayerAnimation()
    {
        if(_horizontalInput < 0)
        {
            _sR.flipX = true;
            _anim.SetBool("walk", true);
        }
        else if(_horizontalInput > 0)
        {
            _sR.flipX = false;
            _anim.SetBool("walk", true);
        }
        else
        {
            _anim.SetBool("walk", false);
        }

    }//PlayerAnimation

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground")
        {
            _isGrounded = true;
        }
        if (target.gameObject.tag == "Enemy") 
        {
            _gameOverPanel.SetActive(true);
            Destroy(this.gameObject);
             
        }

    }//OnCollisionEnter2D

}//classs
