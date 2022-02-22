using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightday : MonoBehaviour
{
   
    public Light lt;


    public void Test()
    {
        if(lt.intensity == 1){
            lt.intensity = 0;
        }
        else
        {
            lt.intensity = 1;
        }
    }

}
