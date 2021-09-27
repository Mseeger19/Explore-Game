using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public int speed = 1;

    private Rigidbody2D rigidbody2d;

     public Sprite idle;
    public Sprite flying; 

    private BoxCollider2D boxCollider2d;

    float currentTime = 0f;
    float startingTime = 2f; 

    // Start is called before the first frame update
    void Start()
    {
       // GetComponent<Animator>().enabled = false;
        currentTime = startingTime; 
       
    }

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>(); 
    }


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate((Vector2.right * Time.deltaTime) * speed); 
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate((Vector2.left * Time.deltaTime) * speed); 
        }


        if(Input.GetKey(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = flying; 
           // GetComponent<Animator>().enabled = true;
        }

        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = idle; 
        }
        
       

    }

    

}
