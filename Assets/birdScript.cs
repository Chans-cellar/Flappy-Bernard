using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "madBird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength ;
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        logic.gameOver();
        birdIsAlive = false;

    }
}
