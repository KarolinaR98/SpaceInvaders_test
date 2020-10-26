using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float speed;
    [SerializeField] private Transform bulletTransform;
    [SerializeField] private GameObject bulletPrefab;
    public int points;
    public int numOLives;
    [SerializeField]private Text pointsText;
    private float timer;
    private Vector3 setPlayerPosition = new Vector3 (0, -3.5f, 0);


    void Start()
    {
        
    }

    
    void Update()
    {
        if (GameManager.playGame)
        {
            BulletGenerator();
        }
        
        TextPoints();
        
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

    void TextPoints()
    {
        pointsText.text = "Points: " + points;
    }

    void CheckIfEndOfGame()
    {
        if(numOLives == -3)
        {
            Debug.Log("End of game");
            GameManager.playGame = false;
            
            
           
                 
        }
        else
        {
            Debug.Log("tada");
            gameObject.transform.position = setPlayerPosition;
        }
    }
}
