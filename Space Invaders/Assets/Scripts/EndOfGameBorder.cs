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
    private int indexOfStat;

   
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
            IfIsInStatistics();
        
            
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

        int numberToCompare = playerPoints;

        for (int i = 0; i < 10; i++)
        {
            if (numberToCompare > GameManager.stats[i])
            {
                int x = GameManager.stats[i];
                GameManager.stats[i] = numberToCompare;
                numberToCompare = x;
                GameManager.isInStatistic = true;
               
            }
            
        }
    }

    void IfIsInStatistics()
    {
        if (GameManager.isInStatistic)
        {
            for(int i = 0; i < 10; i++)
            {
                if (playerPoints == GameManager.stats[i])
                {
                    indexOfStat = i+1;
                    break;
                }
            }
        }

        stats.text = "Your score in ranking is at the place: " + indexOfStat; 
    }
}
