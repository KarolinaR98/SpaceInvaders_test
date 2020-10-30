using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform bullet;
    private void Start()
    {
        bullet = GetComponent<Transform>();
    }
    void FixedUpdate()
    {

        bullet.position += Vector3.up * (-speed);

        if (transform.position.y <= (-3.8) || GameManager.playGame == false)
        {
            Destroy(gameObject);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2" || collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), bullet.GetComponent<Collider2D>());
        }

        if(collision.gameObject.tag == "Player")
        {
            
            collision.gameObject.GetComponent<Player>().numOLives--;
            Destroy(gameObject);
            collision.gameObject.BroadcastMessage("CheckIfEndOfGame", SendMessageOptions.DontRequireReceiver);
        }

    

    }
}
