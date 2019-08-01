using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   public float Speed;
   public bool xMove;
   public bool yMove;
   private bool reverse;
   private bool isRight;
   public bool animated;
   public float smooth;
   private SpriteRenderer sprite;
   
   
   
   private Rigidbody2D Enemy;
   
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer> ();
        Enemy= GetComponent<Rigidbody2D>();
      reverse = false;
    }

    // Update is called once per frame
    void Update()
    {
        SetEnemyMovement();
        
    }

    void FixedUpdate()
    {
        
        
        if (Speed > 0 && animated == true){
            sprite.flipX = true;
            
        }
        if (Speed < 0 && animated == true){
            sprite.flipX= false;
            
        }
    }
    void SetEnemyMovement()
    {
        if (xMove == true)
        {
            transform.position+= transform.right * Speed*Time.deltaTime;
        }
        if (yMove == true)
        {
           transform.position+= transform.up *Speed*Time.deltaTime;
        }
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("EnBounds"))
        {
           Speed= -Speed;
        }
    }
    
}

