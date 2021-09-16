using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private bool choque = false;
    private bool choque2 = true;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (choque == false)
        {
            rb.velocity = new Vector2(-5, rb.velocity.y);
            Debug.Log("Choqueee:");
            sr.flipX = true;
            choque = false;
        }        
        if (choque2 == true) 
        { 
            rb.velocity = new Vector2(-5, rb.velocity.y);
            sr.flipX = true;
            choque2 = false;
            Debug.Log("Choqueee:");
        }

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
       
        if (collider.gameObject.tag == "chocar")
        {
            Debug.Log("Choqueee:");
            rb.velocity = new Vector2(12, rb.velocity.y);
            sr.flipX = false;
            choque = true;
        }
        if (collider.gameObject.tag == "choque2")
        {
            Debug.Log("Choque");
            rb.velocity = new Vector2(-15, rb.velocity.y);
            sr.flipX = true;
            choque2 = false;
        }        
    }
}
