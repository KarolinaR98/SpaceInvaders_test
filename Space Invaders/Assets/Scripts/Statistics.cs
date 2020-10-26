using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public static int[] stats = new int[10];
    [SerializeField]private Text no1, no2, no3, no4, no5, no6, no7, no8, no9, no10, numOfPlay;
        
    void Update()
    {
        no1.text = "1st Ponits: " + GameManager.stats[0];
        no2.text = "2nd Ponits: " + GameManager.stats[1];
        no3.text = "3rd Ponits: " + GameManager.stats[2];
        no4.text = "4th Ponits: " + GameManager.stats[3];
        no5.text = "5th Ponits: " + GameManager.stats[4];
        no6.text = "6th Ponits: " + GameManager.stats[5];
        no7.text = "7th Ponits: " + GameManager.stats[6];
        no8.text = "8th Ponits: " + GameManager.stats[7];
        no9.text = "9th Ponits: " + GameManager.stats[8];
        no10.text = "10th Ponits: " + GameManager.stats[9];

        numOfPlay.text = "Number of finished games: " + GameManager.howManyPlay;

    }

    
}
