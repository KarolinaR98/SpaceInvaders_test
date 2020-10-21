using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float speed;
    [SerializeField] private Transform bulletTransform;
    [SerializeField] private GameObject bulletPrefab;
    private float timer;


    void Start()
    {
        
    }

    
    void Update()
    {
        BulletGenerator();
        
    }

    private void MoveLeft()
    {
        if(transform.position.x > (-2.4))
        {
            transform.position += Vector3.left * speed;
        }
    }

    public void MoveRight()
    {
        if(transform.position.x < 2.4)
        {
            transform.position += Vector3.right * speed;
        }
    }

    public void BulletGenerator()
    {
        timer -= Time.deltaTime;

        if(timer <= 0f)
        {
            Instantiate(bulletPrefab, bulletTransform.transform.position, bulletTransform.transform.rotation);

            timer = 2f;
        }
    }
}
