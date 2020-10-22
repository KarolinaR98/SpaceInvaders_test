using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]private Transform enemies;
    private float speed = 1f;
    void Start()
    {
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemies = GetComponent<Transform>();
    }


    void Update()
    {
        
    }

    void MoveEnemy()
    {
        enemies.position += Vector3.right * speed;

        foreach (Transform enemy in enemies)
        {
            if(enemy.position.x > (-2.4) || enemy.position.x > 2.4)
            {
                speed = -speed;
                enemies.position += Vector3.down * 0.1f;
                return;
            }
        }
    }
}
