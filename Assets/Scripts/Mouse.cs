using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float moveSpeed=0.005f;
    void Start(){

    }
    void Update()
    {
    transform.position=Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition),moveSpeed);
    Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
    difference.Normalize();
    }
}
