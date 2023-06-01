using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovingScript : MonoBehaviour
{
    //Identifies the rate that the pipes move and when they despawn.
    public float moveSpeed = 5f;
    public float deadZone = -45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The position of the pipe is equal to its curent position and the speed that it is moving left relative to time
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);
        //if the position of the pipe is greater than the dead zone, the pipe is despawned
    if (transform.position.x < deadZone){
        Destroy(gameObject);
    }
    }
}
