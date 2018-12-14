using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour {
    private GameObject obj;
    public GameObject gameController;
    public float flyPow;

    public AudioClip flyClip;
    public AudioClip gameOverClip;
    private AudioSource audioSource;

    private Animator anim;
    // Use this for initialization
    void Start ()
    {
        obj = gameObject;
        Time.timeScale = 0;
        audioSource= obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
        flyPow = 300;

        anim=obj.GetComponent<Animator>();
        anim.SetFloat("flyPower", 0);
        anim.SetBool("isDead", false);
        
    }
	
	// Update is called once per frame
	void Update ()
    {
    if (Input.GetMouseButtonDown(0))
        {
            if(!gameController.GetComponent<gameController>().isEndGame && !gameController.GetComponent<gameController>().isStartGame )
            {
                Time.timeScale = 1;
                audioSource.Play();
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPow));      
            }                           
             
        }
        anim.SetFloat("flyPower", obj.GetComponent<Rigidbody2D>().velocity.y);
    }
    void EndGame()
    {
        anim.SetBool("isDead", true);
        audioSource.clip = gameOverClip;
        audioSource.Play();       
        gameController.GetComponent<gameController>().EndGame();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameController.GetComponent<gameController>().isEndGame)
        { EndGame(); }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        gameController.GetComponent<gameController>().GetPoint();
    }
}
