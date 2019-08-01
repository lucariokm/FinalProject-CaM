using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorbutton : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteR;

    public bool pressed;

    public GameObject player;
    private PlayerController playercontroller;
    public GameObject door;
    public AudioSource sfxsource;
    public AudioClip sfx;

    // Start is called before the first frame update
    void Start()
    {
        playercontroller= player.GetComponent<PlayerController>();
        sfxsource = GetComponent<AudioSource>();
        sfxsource.clip = sfx;
        spriteR = GetComponent<SpriteRenderer>();
        if (spriteR.sprite == null) 
        spriteR.sprite = sprite1;
        pressed=false;
    }

    // Update is called once per frame
    void Update()
    {
       if (spriteR.sprite == sprite2 && playercontroller.score == 4) 
       {
           door.SetActive (false);
           
       }
       else
       {
           door.SetActive(true);
       }
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
           pressed = true;

           spriteR.sprite = sprite2;
           sfxsource.Play();
        }
    }

}
