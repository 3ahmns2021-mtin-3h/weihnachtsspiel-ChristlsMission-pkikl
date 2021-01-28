using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{   
    public float speed;
    public TextMeshProUGUI score;
    public TextMeshProUGUI scoreBag;
    
    int countCollision = 0;
    int collisionToScore = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        score.text = "Score: 0";
        scoreBag.text = "0";
    }

    // Update is called once per frame
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(moveHorizontal, 0, 0);

        scoreBag.text = countCollision.ToString();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy(Clone)")
        {
            Debug.Log("-1");
            if (countCollision > 0)
            {
                countCollision--;
            }
      
            Destroy(collision.gameObject);
        }
        else if(collision.name == "LetterBox")
        {
            collisionToScore += countCollision;
            score.text = "Score: " + collisionToScore.ToString();
            countCollision = 0;
        }
        else if(collision.name == "Letter(Clone)")
        {
            countCollision++;
            Destroy(collision.gameObject);
        }

  

    }
    
}
