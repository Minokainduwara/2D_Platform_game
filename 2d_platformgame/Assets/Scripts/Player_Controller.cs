using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    private Animator _playerAnime;
    public float speed;
    public float x_axis_Velocity;
    

    void Start()
    {
        _playerAnime = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    void playerMovement()
    {
        x_axis_Velocity = Input.GetAxisRaw("Horizontal");
        _playerRb.velocity = new Vector2(x_axis_Velocity * speed , _playerAnime.velocity.y);

        //Change the direction
        if (x_axis_Velocity != 0)
        {
            transform.localScale = new Vector3(x_axis_Velocity, 1, 1);
        }
    }
}
