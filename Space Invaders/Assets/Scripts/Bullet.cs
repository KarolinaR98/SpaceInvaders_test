using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed= 10f;
    private Rigidbody2D rb;
    private GameObject player;
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");

    }
    void FixedUpdate()
    {

        Vector2 velocity = rb.velocity;
        velocity.y = speed;
        rb.velocity = velocity;

        if (transform.position.y > 3.5 || GameManager.playGame == false)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2")

        {
           
            Destroy(collision.gameObject);
            Destroy(gameObject);
            player.GetComponent<Player>().points++;
            


        }

        if (collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), collision.gameObject.GetComponent<Collider2D>());
        }

    }


}
