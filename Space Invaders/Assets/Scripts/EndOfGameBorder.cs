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


    private void Update()
    {
        if(!GameManager.playGame)
        {
            game.SetActive(false);
            endOfGamePanel.SetActive(true);
            points.text = "Points: " + player.GetComponent<Player>().points;

            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2")
        {
            GameManager.playGame = false;
        }
    }
}
