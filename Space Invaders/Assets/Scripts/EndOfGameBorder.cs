using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfGameBorder : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2")
        {
            Debug.Log("Koniec");
        }
    }
}
