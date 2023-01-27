using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    public bool isJumping;
    public bool doubleJumpState;
    Rigidbody2D rigid;

    public AudioClip audioJump;
    public AudioClip audiolanding;
    //    public AudioClip audioAttack;
    //    public AudioClip audio audioDamaged;
//    public AudioClip audioDie;
//    public AudioClip audioFinish;

    AudioSource audioSource;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (rigid.velocity.y == 0)
            isJumping = false;
        else
            isJumping = true;

        if (isJumping == false)
        {
            doubleJumpState = true;
        }

        if (isJumping == false && Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            audioSource.clip = audioJump;
            audioSource.Play();
        }
        else if (doubleJumpState && Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            doubleJumpState = false;
            audioSource.clip = audioJump;
            audioSource.Play();
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed * (-1))
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
    }
}