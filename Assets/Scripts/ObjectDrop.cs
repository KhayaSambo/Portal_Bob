using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrop : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {   
        if (collision.relativeVelocity.magnitude > 2){
            audioSource.Play();
        };

        Debug.Log("Collided");       
        
    }
}
