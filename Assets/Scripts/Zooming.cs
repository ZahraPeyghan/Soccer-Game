using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zooming : MonoBehaviour
{
    public float zoomSize=15;
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel")>0){
            if(zoomSize>2)
            zoomSize-=1;
        }

         if(Input.GetAxis("Mouse ScrollWheel")<0){
            if(zoomSize<14)
            zoomSize+=1;
        }
        GetComponent<Camera>().orthographicSize=zoomSize;
    }
}
