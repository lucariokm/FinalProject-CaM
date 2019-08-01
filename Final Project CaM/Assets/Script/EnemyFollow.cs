using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    
    public Transform player;
    public Transform returner;
    public float chaseSpeed;
    public float returnSpeed;
    private bool chase; 
    private bool Returntostart;
    // Start is called before the first frame update
    void Start()
    {
       Returntostart = false;
        chase = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Returntostart == true)
        {
            Returning();
        }
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            chase = true;
            Returntostart = false;
        }
    }
    void OnTriggerStay2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (chase== true)
            {

                Chasing();
            }
        }
    }
    void OnTriggerExit2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            chase =false;
            Returntostart = true;
            
        }
    }
    void Chasing()
    {
        transform.position =  Vector3.MoveTowards( transform.position, player.position, chaseSpeed*Time.deltaTime);
    }
    void Returning()
    {
        transform.position =  Vector3.MoveTowards( transform.position, returner.position, chaseSpeed*Time.deltaTime);
        print ("returning");
    }
}
