using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D controller;
    private Vector2 move;
    public float steps = 5f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            Debug.Log("W pressed");
            move = move + new Vector2 (0, steps); 
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S pressed");
            move = move + new Vector2(0, -steps);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D pressed");
            move = move + new Vector2(steps, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A pressed");
            move = move + new Vector2(-steps, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        transform.position = move;
    }
}
