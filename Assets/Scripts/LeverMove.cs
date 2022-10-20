using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeverMove : MonoBehaviour
{
    public float curRot;
    public float speed = 0.01f;
    public bool flag = true;
    public GameObject water;
    public GameObject elect1;
    public GameObject elect2;
    public AudioSource audioSource;

    void Update(){ 
    curRot += gameObject.transform.localRotation.x;
        
         if (curRot < 0 ) {
               if (flag == true ) {
                    flag = false;    
                    audioSource.Play();
      
               }
               water.transform.Translate( Vector3.down * Time.deltaTime * speed );
               elect1.SetActive(false);
               elect2.SetActive(false);
         }

         
    }

         
     }

