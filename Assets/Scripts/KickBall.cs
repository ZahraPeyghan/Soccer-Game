using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickBall : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject top;
    public float speed;
    void Start()
    {
        rb=top.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1)&& Ball.Onay){
        Vector3 direction=-(transform.position-top.transform.position).normalized;
        rb.AddForce(-direction*speed*Time.deltaTime,ForceMode2D.Impulse);
        Ball.Onay=false;
        Ball.flyTokurd=false;
    }
}
}
