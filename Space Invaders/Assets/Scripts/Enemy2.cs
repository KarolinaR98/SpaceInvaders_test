using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{

    [SerializeField] private Transform bulletTransform;
    [SerializeField] private GameObject bulletPrefab;
    private float timer;
    public float x = 7;
    private float timeForShot;

    void Start()
    {
        timer = Random.Range(1,7);
    }


    void Update()
    {

        if (GameManager.playGame)
        {
            timeForShot = Random.Range(x, 7);
            BulletGenerator(timeForShot);
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


