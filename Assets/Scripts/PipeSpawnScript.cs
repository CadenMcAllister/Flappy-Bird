using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        //Calls the spawn pipe method
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //If the timer is less than the spawn tate the timer is equal to the timer plus time.deltaTime
        if (timer < SpawnRate){
            timer = timer + Time.deltaTime;
        }
        else
        {
            //The Spawn Pipe method is called and the timer is reset to 0
        SpawnPipe();
        timer = 0;
        }
    }

    void SpawnPipe()
    {
        //The lowest point the pipe can be spawned is equal to the y position - the height offset. The height offset is added for the highest point.
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
//Creates a new pipe at the x position already given and at any y position between lowestPoint and highestPoint, keeping roatation the same as the parent object.
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
