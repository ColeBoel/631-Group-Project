using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levitate : MonoBehaviour
{
     private Rigidbody playerphysics;
    public float levi = 0.1f;
 
    void Start(){

         playerphysics = GetComponent<Rigidbody>();

    }
    void Update()
    {
        playerphysics.AddForce(Vector3.up *levi);
    }


}
