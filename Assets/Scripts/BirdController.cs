using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    //rigidBody declaration
    public Rigidbody2D rb;

    private LogicManagerScript logic;
    //flap strength, can be changed in Unity Editor
    [SerializeField] private float flapStrength = 10;
    [SerializeField] private bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {   
        //looks for the gameObject with the tag "Logic" which is the LogicManager obj
        //and gets the script component
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //when the Space key is pressed, move the rigidBody up (0,1) multiplied by flapStrength
        //and check if the bird is alive
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true) {
            // Vector2.up is a shortening for moving up a vector of (x = 0, y = 1)
            rb.velocity = Vector2.up * flapStrength;
        }

        //give a gameOver screen if you go out of bounds in the game
        if (transform.position.y > 20 || transform.position.y < -20)
        {
            GiveGameOverScreen();
        } 
    }
    //function to give a gameOver screen so that there is no duplicates of code
    public void GiveGameOverScreen()
    {
        //get the gameover screen and set bird is alive to false so you cant play after a gameOver
        logic.gameOver();
        birdIsAlive= false;
    }

    //detects the collision of the bird with the pipe and calls the gameOver function in LogicManagerScript
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GiveGameOverScreen();
    }
}