using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float inputX = Input.GetAxis("Horizontal");
       float inputY = Input.GetAxis("Jump");

       Vector2 movement = new Vector2(speed.x * inputX, speed.y * inputY);

       movement *= Time.deltaTime;
       transform.Translate(movement);

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
        
    }
    
        
}
