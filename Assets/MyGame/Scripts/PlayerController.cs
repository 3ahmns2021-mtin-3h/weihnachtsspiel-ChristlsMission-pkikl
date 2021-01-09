using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float speed;



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
}
