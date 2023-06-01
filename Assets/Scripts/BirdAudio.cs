using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAudio : MonoBehaviour
{
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        //Finds the logic script
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the space key is pressed and the bird is alive move up by the value of flapStrength multiplied by the up direction
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true){
            audioSource.Play();
        }
    }
//If the bird hits the pipe the GameOverScreen is displayed and the bird is dead
    private void OnCollisionEnter2D(Collision2D collision){
        logic.GameOver();
        birdIsAlive = false;
    }
}
