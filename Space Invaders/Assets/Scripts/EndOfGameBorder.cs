using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfGameBorder : MonoBehaviour {
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject endOfGamePanel;
    [SerializeField] private Text points;
    [SerializeField] private Text stats;
    private int playerPoints;

   
    private void Update()
    {
        playerPoints = player.GetComponent<Player>().points;

        if (!GameManager.playGame)
        {
            game.SetActive(false);
            endOfGamePanel.SetActive(true);
            points.text = "Points: " + playerPoints;
            GameManager.shootFrequency = 7;
            GameManager.speedOfMovement = 0.8f;
            GameManager.howManyPlay++;
            GameManager.points = playerPoints;
            CheckIfInStats();
            Debug.Log(GameManager.stats[0]);
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2")
        {
            GameManager.playGame = false;
        }
    }

    void CheckIfInStats()
    {
        for (int i = 0; i < 10; i++)
        {
            if (playerPoints > GameManager.stats[i])
            {
                if(GameManager.stats[i] > GameManager.stats[i + 1])
                {
                    GameManager.stats[i + 1] = GameManager.stats[i];

                }
                GameManager.stats[i] = playerPoints;
               
            }
            
        }
    }

}
