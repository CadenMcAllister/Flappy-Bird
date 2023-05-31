using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAudio : MonoBehaviour
{
    public Rigidbody2D bird;
    public AudioSource audioSource;
    public AudioClip clip;
    public BirdScript birdScript;
    
    // Start is called before the first frame update
    void Start()
    {
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown(KeyCode.Space)){
        }
    }
}
