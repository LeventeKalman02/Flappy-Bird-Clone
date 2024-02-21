using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    //declaring the pipe Prefab
    [SerializeField] private GameObject pipe;
    //Used to adjust the rate at which pipes spawn
    [SerializeField] private float spawnRate = 3;
    private float timer = 0;

    [SerializeField] private float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //check if the timer is less than the spawnrate
        if (timer < spawnRate)
        {
            //add the time to the timer so that pipes spawn at regular intervals
            timer = timer + Time.deltaTime;
        }
        else
        {
            //spawn a pipe and reset timer back to 0
            spawnPipe();
            timer = 0;
        }        
    }

    void spawnPipe()
    {
        //sets the range used for spawning the pipes above and below the bird
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        //spawns a new pipe at a different height every time
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
