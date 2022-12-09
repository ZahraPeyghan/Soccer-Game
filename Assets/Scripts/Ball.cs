using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject kurdpro; 
    Vector2 kurdDirection;
    float timeStamp;
    public static bool flyTokurd;
    [Header ("Vurma")]
    [HideInInspector]
    public bool lookingRight=true;
    private Rigidbody2D rb2d;
    public GameObject top;
    public static bool Onay;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        if(flyTokurd){
            kurdDirection=-(transform.position-kurdpro.transform.position).normalized;
            rb.velocity=new Vector2(kurdDirection.x,kurdDirection.y)*5f*(Time.time/timeStamp); 
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name.Equals("PlayerMagnet")){
            timeStamp=Time.time;
            kurdpro=GameObject.Find("Player");
            flyTokurd=true;
            Onay=true;
        }
    }

    void OnTriggerExit2D(Collider2D col){
        flyTokurd=false;
    }
      
}
