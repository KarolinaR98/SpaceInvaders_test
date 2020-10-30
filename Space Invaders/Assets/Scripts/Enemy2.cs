using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{

    [SerializeField] private Transform bulletTransform;
    [SerializeField] private GameObject bulletPrefab;
    private float timer;
    private float timeForShot;

    void Start()
    {
        timer = Random.Range(1,4);
    }


    void Update()
    {

        if (GameManager.playGame)
        {
            
            BulletGenerator(GameManager.shootFrequency);
        }
            
    }


    public void BulletGenerator(float timeForShot)
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            Instantiate(bulletPrefab, bulletTransform.transform.position, bulletTransform.transform.rotation);

            timer = timeForShot;
        }
       
    }


    


}


