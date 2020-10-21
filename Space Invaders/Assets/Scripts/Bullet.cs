using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed= 10f;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }
    void Update()
    {
        Vector2 velocity = rb.velocity;
        velocity.y = speed;
        rb.velocity = velocity;

        if (transform.position.y > 3.5)
        {
            Destroy(gameObject);
        }
    }


}
