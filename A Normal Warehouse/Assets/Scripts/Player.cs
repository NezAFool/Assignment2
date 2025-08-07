using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    private Rigidbody2D controller;
    private float move;
    private Vector2 vec2;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    //void PlayerMove()
    //{
    //    move = move + new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        
    //}

    // Update is called once per frame
    void Update()
    {
        
        move = Input.GetAxis("Horizontal");
        controller.velocity = new Vector2(move * speed, controller.velocity.y);


        move = Input.GetAxis("Vertical");
        controller.velocity = new Vector2(controller.velocity.x, move * speed);

    }
}
