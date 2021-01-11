using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float speed;
    int countCollision = 0;


    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
    }

    // Update is called once per frame
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(moveHorizontal, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy")
        {
            Debug.Log("-1");
            countCollision--;
        }
        else if(collision.name == "LetterBox")
        {
            countCollision = 0;
        }
        else if(collision.name == "BriefWhitebox")
        {
            countCollision++;
        }

        Debug.Log("Count Collisions " + countCollision);

    }
}
