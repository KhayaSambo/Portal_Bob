using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed = -0.025f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.up * Time.deltaTime * speed );
    }
}
