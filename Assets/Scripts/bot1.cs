using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot1 : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform target;
    void Start()
    {
        target=GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
    }
}
