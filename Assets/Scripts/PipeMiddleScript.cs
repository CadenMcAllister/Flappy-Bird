using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        //finds the logic script
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //If the bird passes through the trigger in the middle of the pipe then the score is increased by 1 (The bird is on layer 3)
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer == 3){
        logic.addScore(1);
        }
    }
}
