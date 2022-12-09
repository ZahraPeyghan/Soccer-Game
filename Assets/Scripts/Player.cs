using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     Rigidbody2D rb;
    float dirx,moveSpeed=5f;
    [SerializeField] GameObject playMognet;
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
       dirx=Input.GetAxisRaw("Horizontal")*moveSpeed;
       playMognet.transform.position=new Vector2(transform.position.x,transform.position.y);

       if(Input.GetButtonDown("Fire") && rb.velocity.y==0){
        rb.AddForce(Vector2.up*700f);
       }
   } 
    void FixedUpdate(){
        rb.velocity=new Vector2(dirx,rb.velocity.y);
    }
}
