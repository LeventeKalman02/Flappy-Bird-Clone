using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    //speed of the pipe, can be adjusted in Unity Editor
    [SerializeField] private float pipeMoveSpeed = 5;
    [SerializeField] private float deadZone = -50;

    // Update is called once per frame
    void Update()
    {
        //makes the pipe move from right to left at a constant rate
        //multiplied by Time.deltaTime for the constant rate of movement
        transform.position = transform.position + (Vector3.left * pipeMoveSpeed) * Time.deltaTime;

        //delete the game object if it hits -30 on the x coordinate
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
