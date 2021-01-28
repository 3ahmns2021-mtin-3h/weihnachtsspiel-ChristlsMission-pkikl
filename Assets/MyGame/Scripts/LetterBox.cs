using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBox : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    public float movement = -4.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ColliderLetterBox")
        {
            movement = 4.0f;
        }
        if (collision.name == "ColliderLetterBoxBack")
        {
            movement = -4.0f;
        }

    }
    // Update is called once per frame
    void Update()
    {
      
     rb.velocity = new Vector2(movement * speed, rb.velocity.y); 
        
    }
}
