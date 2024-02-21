using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTriggerScript : MonoBehaviour
{
    //creates an instance of the Logic Manager Script in this script
    private LogicManagerScript logic;

    // Start is called before the first frame update
    void Start()
    {
        //looks for the gameObject with the tag "Logic" which is the LogicManager obj
        //and gets the script component
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    //function for increasing the score on trigger with the collider between the pipes
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if the player is actually what went through the trigger
        //by checking the layer that is assigned to the bird
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }        
    }
}
