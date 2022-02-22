using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour
{

    public Camera cam1;
    public Camera cam2;

    public void Test(){

        if(cam2.enabled == false){
        cam1.enabled = false;
        cam2.enabled = true;
        }
        else{
        cam1.enabled = true;
        cam2.enabled = false;
        }
    
        
    }
}
