using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashSound : MonoBehaviour
{
    public AudioSource source;
 
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
       if (collision.gameObject.tag != "Player") {
        
        source.Play();
        Debug.Log("Played");

        }
    }
     
}
