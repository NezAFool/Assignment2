using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    //Its a basic player controller
    private Rigidbody2D controller;
    private float move;
    public float speed = 5f;
    
    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        move = Input.GetAxis("Horizontal");
        controller.velocity = new Vector2(move * speed, controller.velocity.y);


        move = Input.GetAxis("Vertical");
        controller.velocity = new Vector2(controller.velocity.x, move * speed);

    }
}
