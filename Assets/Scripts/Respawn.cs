using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform Handle;
    public Transform Ball;
    public Transform Shaft;
    public Transform Ammo;
    public Transform Body;

    public Transform gunRespawn;

    public Transform respawn;

    public AudioSource audioSource;

    void OnTriggerEnter(Collider other) 
    {
        if( other.gameObject.tag == "Player" )
        {
            player.transform.position = respawn.transform.position;
            audioSource.Play();
            //SceneManager.LoadScene("SciFi_Warehouse");
           
        }

        if( other.gameObject.layer == 24 )
        {
            Handle.transform.position = gunRespawn.transform.position;
           
        }
        if( other.gameObject.layer == 23 )
        {
            Ball.transform.position = gunRespawn.transform.position;
           
        }
        if( other.gameObject.layer == 19 )
        {
            Shaft.transform.position = gunRespawn.transform.position;

        }
        if( other.gameObject.layer == 18 )
        {
            Ammo.transform.position = gunRespawn.transform.position;
           
        }
        if( other.gameObject.layer == 21 )
        {
            Body.transform.position = gunRespawn.transform.position;
           
        }

    }
}
