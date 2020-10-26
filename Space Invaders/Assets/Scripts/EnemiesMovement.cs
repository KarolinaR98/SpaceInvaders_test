using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
    private float timer = 0;
    private float step = 0.1f;
    private float timeToMove = 0.8f;
    [SerializeField] private Transform enemies;
   
    
    

    void Update()
    {
        if (GameManager.playGame)
        {
            Movement();
        }

    }

    void Movement()
    {
        timer += Time.deltaTime;
        if (timer > GameManager.speedOfMovement)
        {
            foreach (Transform enemy in enemies)
            {
                enemies.transform.Translate(new Vector3(step, 0, 0));
                if (enemies.position.x >= 1.25 || enemies.position.x <= (-0.5f))
                {                 
                    enemies.transform.Translate(new Vector3(0, -0.5f, 0));
                    step = -step;
                    
                }

             
                
                timer = 0;
                
            }
                         
            
        }

 
              
        
    }

    
}
